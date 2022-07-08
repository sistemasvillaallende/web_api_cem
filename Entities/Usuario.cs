using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Web_Api_Cem.Entities
{
    public class Usuario : DALBase
    {
        public int cod_usuario { get; set; }
        public string nombre { get; set; }
        public int legajo { get; set; }
        public bool administrador { get; set; }
        public string nombre_completo { get; set; }
        public string passwd { get; set; }
        public string email { get; set; }
        public bool baja { get; set; }
        public int cod_oficina { get; set; }
        public string nombre_oficina { get; set; }

        public Usuario() { }


        public static Usuario ValidUser(string user, string password)
        {
            Usuario obj = null;
            string md5Passwd = "";
            string md5Passwd_ = "";
            MD5Encryption encript= new MD5Encryption();

            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = null;
            StringBuilder strSQL = new StringBuilder();

            MD5Encryption objMD5 = new MD5Encryption();

            user = user.Replace("'", "").Replace(",", "").Replace("=", "");

            strSQL.AppendLine("SELECT * From USUARIOS_V2 WHERE nombre = @user");

            cmd = new SqlCommand();

            cmd.Parameters.Add(new SqlParameter("@user", user));
            try
            {
                cn = getConnection();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL.ToString();
                cmd.Connection.Open();

                dr = cmd.ExecuteReader();
                int COD_USUARIO = dr.GetOrdinal("COD_USUARIO");
                int NOMBRE = dr.GetOrdinal("NOMBRE");
                int LEGAJO = dr.GetOrdinal("LEGAJO");
                int ADMINISTRADOR = dr.GetOrdinal("ADMINISTRADOR");
                int NOMBRE_COMPLETO = dr.GetOrdinal("NOMBRE_COMPLETO");
                int PASSWD = dr.GetOrdinal("PASSWD");
                int EMAIL = dr.GetOrdinal("EMAIL");
                int BAJA = dr.GetOrdinal("BAJA");
                while (dr.Read())
                {
                    md5Passwd = dr.GetString(dr.GetOrdinal("passwd"));
                    md5Passwd_ = encript.EncryptMD5(password.Trim().ToUpper() + user.Trim().ToUpper());
                    if (md5Passwd == md5Passwd_)
                    {
                        obj = new Usuario();
                        if (!dr.IsDBNull(ADMINISTRADOR))
                            obj.administrador = dr.GetBoolean(ADMINISTRADOR);
                        if (!dr.IsDBNull(BAJA))
                            obj.baja = dr.GetBoolean(BAJA);
                        if (!dr.IsDBNull(COD_USUARIO))
                            obj.cod_usuario = dr.GetInt32(COD_USUARIO);
                        if (!dr.IsDBNull(EMAIL))
                            obj.email = dr.GetString(EMAIL);
                        if (!dr.IsDBNull(LEGAJO))
                            obj.legajo = dr.GetInt32(LEGAJO);
                        if (!dr.IsDBNull(NOMBRE))
                            obj.nombre = dr.GetString(NOMBRE);
                        if (!dr.IsDBNull(NOMBRE_COMPLETO))
                            obj.nombre_completo = dr.GetString(NOMBRE_COMPLETO);
                        if (!dr.IsDBNull(PASSWD))
                            obj.passwd = dr.GetString(PASSWD);
                    }

                }
                return obj;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Error en la Autenticación!!!.");
            }

            finally
            {
                cn.Close();
                objMD5 = null;
            }
        }
        public static Usuario getByPk(int ID)
        {
            Usuario obj = null;

            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = null;
            StringBuilder strSQL = new StringBuilder();


            strSQL.AppendLine("SELECT A.*, B.NOMBRE_OFICINA From USUARIOS_V2 A");
            strSQL.AppendLine("INNER JOIN OFICINAS B ON A.COD_OFICINA = B.CODIGO_OFICINA");
            strSQL.AppendLine("WHERE nombre = @user");

            cmd = new SqlCommand();

            cmd.Parameters.Add(new SqlParameter("@COD_USUARIO", ID));
            try
            {
                cn = getConnection();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL.ToString();
                cmd.Connection.Open();

                dr = cmd.ExecuteReader();
                int COD_USUARIO = dr.GetOrdinal("COD_USUARIO");
                int NOMBRE = dr.GetOrdinal("NOMBRE");
                int LEGAJO = dr.GetOrdinal("LEGAJO");
                int ADMINISTRADOR = dr.GetOrdinal("ADMINISTRADOR");
                int NOMBRE_COMPLETO = dr.GetOrdinal("NOMBRE_COMPLETO");
                int PASSWD = dr.GetOrdinal("PASSWD");
                int EMAIL = dr.GetOrdinal("EMAIL");
                int BAJA = dr.GetOrdinal("BAJA");
                int NOMBRE_OFICINA = dr.GetOrdinal("NOMBRE_OFICINA");
                while (dr.Read())
                {
                    obj = new Usuario();
                    if (!dr.IsDBNull(ADMINISTRADOR))
                        obj.administrador = dr.GetBoolean(ADMINISTRADOR);
                    if (!dr.IsDBNull(BAJA))
                        obj.baja = dr.GetBoolean(BAJA);
                    if (!dr.IsDBNull(COD_USUARIO))
                        obj.cod_usuario = dr.GetInt32(COD_USUARIO);
                    if (!dr.IsDBNull(EMAIL))
                        obj.email = dr.GetString(EMAIL);
                    if (!dr.IsDBNull(LEGAJO))
                        obj.legajo = dr.GetInt32(LEGAJO);
                    if (!dr.IsDBNull(NOMBRE))
                        obj.nombre = dr.GetString(NOMBRE);
                    if (!dr.IsDBNull(NOMBRE_COMPLETO))
                        obj.nombre_completo = dr.GetString(NOMBRE_COMPLETO);
                    if (!dr.IsDBNull(PASSWD))
                        obj.passwd = dr.GetString(PASSWD);
                    if (!dr.IsDBNull(NOMBRE_OFICINA))
                        obj.nombre_oficina = dr.GetString(NOMBRE_OFICINA);
                }
                return obj;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Error en la Autenticación!!!.");
            }

            finally
            {
                cn.Close();
            }
        }
    }
}
