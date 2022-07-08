using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Web_Api_Cem.Entities
{
    public class CATE_DEUDA_CEMENTERIO : DALBase
    {
        public int cod_categoria { get; set; }
        public string des_categoria { get; set; }
        public int id_subrubro { get; set; }

        public CATE_DEUDA_CEMENTERIO()
        {
            cod_categoria = 0;
            des_categoria = string.Empty;
            id_subrubro = 0;
        }

        private static List<CATE_DEUDA_CEMENTERIO> mapeo(SqlDataReader dr)
        {
            List<CATE_DEUDA_CEMENTERIO> lst = new List<CATE_DEUDA_CEMENTERIO>();
            CATE_DEUDA_CEMENTERIO obj;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    obj = new CATE_DEUDA_CEMENTERIO();
                    if (!dr.IsDBNull(0)) { obj.cod_categoria = dr.GetInt32(0); }
                    if (!dr.IsDBNull(1)) { obj.des_categoria = dr.GetString(1); }
                    if (!dr.IsDBNull(2)) { obj.id_subrubro = dr.GetInt32(2); }
                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<CATE_DEUDA_CEMENTERIO> read()
        {
            try
            {
                List<CATE_DEUDA_CEMENTERIO> lst = new List<CATE_DEUDA_CEMENTERIO>();
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT *FROM CATE_DEUDA_CEMENTERIO";
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

        public static CATE_DEUDA_CEMENTERIO getByPk(
        int cod_categoria)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT *FROM CATE_DEUDA_CEMENTERIO WHERE");
                sql.AppendLine("cod_categoria = @cod_categoria");
                CATE_DEUDA_CEMENTERIO obj = null;
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@cod_categoria", cod_categoria);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<CATE_DEUDA_CEMENTERIO> lst = mapeo(dr);
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

        public static int insert(CATE_DEUDA_CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO CATE_DEUDA_CEMENTERIO(");
                sql.AppendLine("cod_categoria");
                sql.AppendLine(", des_categoria");
                sql.AppendLine(", id_subrubro");
                sql.AppendLine(")");
                sql.AppendLine("VALUES");
                sql.AppendLine("(");
                sql.AppendLine("@cod_categoria");
                sql.AppendLine(", @des_categoria");
                sql.AppendLine(", @id_subrubro");
                sql.AppendLine(")");
                sql.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection con =getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@cod_categoria", obj.cod_categoria);
                    cmd.Parameters.AddWithValue("@des_categoria", obj.des_categoria);
                    cmd.Parameters.AddWithValue("@id_subrubro", obj.id_subrubro);
                    cmd.Connection.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(CATE_DEUDA_CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  CATE_DEUDA_CEMENTERIO SET");
                sql.AppendLine("des_categoria=@des_categoria");
                sql.AppendLine(", id_subrubro=@id_subrubro");
                sql.AppendLine("WHERE");
                sql.AppendLine("cod_categoria=@cod_categoria");
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@cod_categoria", obj.cod_categoria);
                    cmd.Parameters.AddWithValue("@des_categoria", obj.des_categoria);
                    cmd.Parameters.AddWithValue("@id_subrubro", obj.id_subrubro);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(CATE_DEUDA_CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE  CATE_DEUDA_CEMENTERIO ");
                sql.AppendLine("WHERE");
                sql.AppendLine("cod_categoria=@cod_categoria");
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@cod_categoria", obj.cod_categoria);
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

