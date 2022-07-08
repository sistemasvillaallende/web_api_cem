using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Web_Api_Cem.Entities
{
    public class DIFUNTOS : DALBase
    {
        public string tipo { get; set; }
        public int manzana { get; set; }
        public int lote { get; set; }
        public int parcela { get; set; }
        public int nivel { get; set; }
        public DateTime fecha_alta_registro { get; set; }
        public string nom_difunto { get; set; }
        public int tipo_documento { get; set; }
        public string nro_documento { get; set; }

        public string tipo_doc_nombre { get; set; }

        public DIFUNTOS()
        {
            tipo = string.Empty;
            manzana = 0;
            lote = 0;
            parcela = 0;
            nivel = 0;
            fecha_alta_registro = DateTime.Now;
            nom_difunto = string.Empty;
            tipo_documento = 0;
            nro_documento = string.Empty;
            tipo_doc_nombre = string.Empty;

        }

        private static List<DIFUNTOS> mapeo(SqlDataReader dr)
        {
            List<DIFUNTOS> lst = new List<DIFUNTOS>();
            DIFUNTOS obj;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    obj = new DIFUNTOS();
                    if (!dr.IsDBNull(0)) { obj.tipo = dr.GetString(0); }
                    if (!dr.IsDBNull(1)) { obj.manzana = dr.GetInt32(1); }
                    if (!dr.IsDBNull(2)) { obj.lote = dr.GetInt32(2); }
                    if (!dr.IsDBNull(3)) { obj.parcela = dr.GetInt32(3); }
                    if (!dr.IsDBNull(4)) { obj.nivel = dr.GetInt32(4); }
                    if (!dr.IsDBNull(5)) { obj.fecha_alta_registro = dr.GetDateTime(5); }
                    if (!dr.IsDBNull(6)) { obj.nom_difunto = dr.GetString(6); }
                    if (!dr.IsDBNull(7)) { obj.tipo_documento = dr.GetInt32(7); }
                    if (!dr.IsDBNull(8)) { obj.nro_documento = dr.GetString(8); }
                    if (!dr.IsDBNull(8)) { obj.tipo_doc_nombre = dr.GetString(9); }
                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<DIFUNTOS> read()
        {
            try
            {
                List<DIFUNTOS> lst = new List<DIFUNTOS>();
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM DIFUNTOS";
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                   // List<T> result = new List<T>();
                   // SqlDataReader reader = com.ExecuteReader();

                    while (dr.Read())
                    {
                        Type type = typeof(DIFUNTOS);
                        DIFUNTOS obj = (DIFUNTOS)Activator.CreateInstance(type);
                        PropertyInfo[] properties = type.GetProperties();

                        foreach (PropertyInfo property in properties)
                        {
                            try
                            {
                                var value = dr[property.Name];
                                if (value != null)
                                    property.SetValue(obj, Convert.ChangeType(value.ToString(), property.PropertyType));
                            }
                            catch { }
                        }
                        lst.Add(obj);
                    }
                   // lst = mapeo(dr);
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<DIFUNTOS> BuscarDifuntos(char Tipo, int Manzana, int Lote, int Parcela, int Nivel)
        {
            try
            {
                List<DIFUNTOS> lst = new List<DIFUNTOS>();
                using (SqlConnection con = getConnection())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("SELECT d.*,t.des_tipo_documento FROM DIFUNTOS d ");
                    sql.AppendLine("    left join TIPOS_DOCUMENTOS t on t.cod_tipo_documento=d.tipo_documento" );
                    sql.AppendLine(" WHERE ");
                    sql.AppendLine(" d.Tipo = @Tipo");
                    sql.AppendLine(" AND d.Manzana = @Manzana");
                    sql.AppendLine(" AND d.Lote = @Lote");
                    sql.AppendLine(" AND d.Parcela = @Parcela");

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo", Tipo);
                    cmd.Parameters.AddWithValue("@Manzana", Manzana);
                    cmd.Parameters.AddWithValue("@Lote", Lote);
                    cmd.Parameters.AddWithValue("@Parcela", Parcela);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    lst = mapeo(dr);
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DIFUNTOS getByPk(
char Tipo, int Manzana, int Lote, int Parcela, int Nivel)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM DIFUNTOS WHERE ");
                sql.AppendLine(" Tipo = @Tipo");
                sql.AppendLine(" AND Manzana = @Manzana");
                sql.AppendLine(" AND Lote = @Lote");
                sql.AppendLine(" AND Parcela = @Parcela");
                //sql.AppendLine(" AND Nivel = @Nivel");
                DIFUNTOS obj = null;
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo", Tipo);
                    cmd.Parameters.AddWithValue("@Manzana", Manzana);
                    cmd.Parameters.AddWithValue("@Lote", Lote);
                    cmd.Parameters.AddWithValue("@Parcela", Parcela);
                    cmd.Parameters.AddWithValue("@Nivel", Nivel);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    List<DIFUNTOS> lst = mapeo(dr);
                    if (lst.Count != 0)
                        obj = lst[0];
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(DIFUNTOS obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO DIFUNTOS(");
                sql.AppendLine("Tipo ");
                sql.AppendLine(", Manzana");
                sql.AppendLine(", Lote");
                sql.AppendLine(", Parcela");
                sql.AppendLine(", Nivel");
                sql.AppendLine(", Fecha_alta_registro");
                sql.AppendLine(", Nom_difunto");
                sql.AppendLine(", Tipo_documento");
                sql.AppendLine(", Nro_documento");
                sql.AppendLine(")");
                sql.AppendLine("VALUES");
                sql.AppendLine("(");
                sql.AppendLine("@Tipo");
                sql.AppendLine(", @Manzana");
                sql.AppendLine(", @Lote");
                sql.AppendLine(", @Parcela");
                sql.AppendLine(", @Nivel");
                sql.AppendLine(", @Fecha_alta_registro");
                sql.AppendLine(", @Nom_difunto");
                sql.AppendLine(", @Tipo_documento");
                sql.AppendLine(", @Nro_documento");
                sql.AppendLine(")");
                sql.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo", obj.tipo);
                    cmd.Parameters.AddWithValue("@Manzana", obj.manzana);
                    cmd.Parameters.AddWithValue("@Lote", obj.lote);
                    cmd.Parameters.AddWithValue("@Parcela", obj.parcela);
                    cmd.Parameters.AddWithValue("@Nivel", obj.nivel);
                    cmd.Parameters.AddWithValue("@Fecha_alta_registro", obj.fecha_alta_registro);
                    cmd.Parameters.AddWithValue("@Nom_difunto", obj.nom_difunto);
                    cmd.Parameters.AddWithValue("@Tipo_documento", obj.tipo_documento);
                    cmd.Parameters.AddWithValue("@Nro_documento", obj.nro_documento);
                    cmd.Connection.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(DIFUNTOS obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  DIFUNTOS SET ");
                sql.AppendLine(" Fecha_alta_registro=@Fecha_alta_registro ");
                sql.AppendLine(", Nom_difunto=@Nom_difunto ");
                sql.AppendLine(", Tipo_documento=@Tipo_documento ");
                sql.AppendLine(", Nro_documento=@Nro_documento ");
                sql.AppendLine("WHERE ");
                sql.AppendLine("Tipo=@Tipo ");
                sql.AppendLine("AND Manzana=@Manzana ");
                sql.AppendLine("AND Lote=@Lote ");
                sql.AppendLine("AND Parcela=@Parcela ");
                sql.AppendLine("AND Nivel=@Nivel ");
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo", obj.tipo);
                    cmd.Parameters.AddWithValue("@Manzana", obj.manzana);
                    cmd.Parameters.AddWithValue("@Lote", obj.lote);
                    cmd.Parameters.AddWithValue("@Parcela", obj.parcela);
                    cmd.Parameters.AddWithValue("@Nivel", obj.nivel);
                    cmd.Parameters.AddWithValue("@Fecha_alta_registro", obj.fecha_alta_registro);
                    cmd.Parameters.AddWithValue("@Nom_difunto", obj.nom_difunto);
                    cmd.Parameters.AddWithValue("@Tipo_documento", obj.tipo_documento);
                    cmd.Parameters.AddWithValue("@Nro_documento", obj.nro_documento);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(DIFUNTOS obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE  DIFUNTOS ");
                sql.AppendLine("WHERE ");
                sql.AppendLine("Tipo=@Tipo ");
                sql.AppendLine("AND Manzana=@Manzana ");
                sql.AppendLine("AND Lote=@Lote ");
                sql.AppendLine("AND Parcela=@Parcela ");
                sql.AppendLine("AND Nivel=@Nivel ");
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo", obj.tipo);
                    cmd.Parameters.AddWithValue("@Manzana", obj.manzana);
                    cmd.Parameters.AddWithValue("@Lote", obj.lote);
                    cmd.Parameters.AddWithValue("@Parcela", obj.parcela);
                    cmd.Parameters.AddWithValue("@Nivel", obj.nivel);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

