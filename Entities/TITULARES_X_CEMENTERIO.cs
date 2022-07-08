using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Web_Api_Cem.Entities
{
    public class TITULARES_X_CEMENTERIO : DALBase
    {
        public string tipo { get; set; }
        public int manzana { get; set; }
        public int lote { get; set; }
        public int parcela { get; set; }
        public int nivel { get; set; }
        public int nro_titular { get; set; }
        public string nom_titular { get; set; }
        public int cod_calle_dom_esp { get; set; }
        public string nom_calle_dom_esp { get; set; }
        public int cod_barrio_dom_esp { get; set; }
        public string nom_barrio_dom_esp { get; set; }
        public int nro_dom_esp { get; set; }
        public string piso_dpto_dom_esp { get; set; }
        public string ciudad_dom_esp { get; set; }
        public string provincia_dom_esp { get; set; }
        public string pais_dom_esp { get; set; }
        public string cod_postal_dom_esp { get; set; }
        public DateTime fecha_cambio_domicilio { get; set; }
        public string cuit { get; set; }
        public Int16 activo { get; set; }

        public TITULARES_X_CEMENTERIO()
        {
            tipo = string.Empty;
            manzana = 0;
            lote = 0;
            parcela = 0;
            nivel = 0;
            nro_titular = 0;
            nom_titular = string.Empty;
            cod_calle_dom_esp = 0;
            nom_calle_dom_esp = string.Empty;
            cod_barrio_dom_esp = 0;
            nom_barrio_dom_esp = string.Empty;
            nro_dom_esp = 0;
            piso_dpto_dom_esp = string.Empty;
            ciudad_dom_esp = string.Empty;
            provincia_dom_esp = string.Empty;
            pais_dom_esp = string.Empty;
            cod_postal_dom_esp = string.Empty;
            fecha_cambio_domicilio = DateTime.Now;
            cuit = string.Empty;
            activo = 0;
        }

        private static List<TITULARES_X_CEMENTERIO> mapeo(SqlDataReader dr)
        {
            List<TITULARES_X_CEMENTERIO> lst = new List<TITULARES_X_CEMENTERIO>();
            TITULARES_X_CEMENTERIO obj;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    obj = new TITULARES_X_CEMENTERIO();
                    if (!dr.IsDBNull(0)) { obj.tipo = dr.GetString(0); }
                    if (!dr.IsDBNull(1)) { obj.manzana = dr.GetInt32(1); }
                    if (!dr.IsDBNull(2)) { obj.lote = dr.GetInt32(2); }
                    if (!dr.IsDBNull(3)) { obj.parcela = dr.GetInt32(3); }
                    if (!dr.IsDBNull(4)) { obj.nivel = dr.GetInt32(4); }
                    if (!dr.IsDBNull(5)) { obj.nro_titular = dr.GetInt32(5); }
                    if (!dr.IsDBNull(6)) { obj.nom_titular = dr.GetString(6); }
                    if (!dr.IsDBNull(7)) { obj.cod_calle_dom_esp = dr.GetInt32(7); }
                    if (!dr.IsDBNull(8)) { obj.nom_calle_dom_esp = dr.GetString(8); }
                    if (!dr.IsDBNull(9)) { obj.cod_barrio_dom_esp = dr.GetInt32(9); }
                    if (!dr.IsDBNull(10)) { obj.nom_barrio_dom_esp = dr.GetString(10); }
                    if (!dr.IsDBNull(11)) { obj.nro_dom_esp = dr.GetInt32(11); }
                    if (!dr.IsDBNull(12)) { obj.piso_dpto_dom_esp = dr.GetString(12); }
                    if (!dr.IsDBNull(13)) { obj.ciudad_dom_esp = dr.GetString(13); }
                    if (!dr.IsDBNull(14)) { obj.provincia_dom_esp = dr.GetString(14); }
                    if (!dr.IsDBNull(15)) { obj.pais_dom_esp = dr.GetString(15); }
                    if (!dr.IsDBNull(16)) { obj.cod_postal_dom_esp = dr.GetString(16); }
                    if (!dr.IsDBNull(17)) { obj.fecha_cambio_domicilio = dr.GetDateTime(17); }
                    if (!dr.IsDBNull(18)) { obj.cuit = dr.GetString(18); }
                    if (!dr.IsDBNull(19)) { obj.activo = dr.GetInt16(19); }
                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<TITULARES_X_CEMENTERIO> read()
        {
            try
            {
                List<TITULARES_X_CEMENTERIO> lst = new List<TITULARES_X_CEMENTERIO>();
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT *FROM TITULARES_X_CEMENTERIO";
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
        public static List<TITULARES_X_CEMENTERIO> listarTitulares(char Tipo, int Manzana, int Lote, int Parcela,
            int Nivel)
        {
            try
            {
                List<TITULARES_X_CEMENTERIO> lst = new List<TITULARES_X_CEMENTERIO>();
                using (SqlConnection con = getConnection())         
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("  SELECT  * from TITULARES_X_CEMENTERIO ");
                    sql.AppendLine("  WHERE  ");
                    sql.AppendLine("   tipo =@tipo AND  ");
                    sql.AppendLine("   manzana =@manzana AND ");
                    sql.AppendLine("   lote =@lote AND  ");
                    sql.AppendLine("   parcela = @parcela AND  ");
                    sql.AppendLine("   nivel =@nivel ");
                    sql.AppendLine("   ORDER BY ACTIVO DESC ");
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@tipo", Tipo);
                    cmd.Parameters.AddWithValue("@manzana", Manzana);
                    cmd.Parameters.AddWithValue("@lote", Lote);
                    cmd.Parameters.AddWithValue("@parcela", Parcela);
                    cmd.Parameters.AddWithValue("@nivel", Nivel);
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

        public static TITULARES_X_CEMENTERIO getByPk(
        char Tipo, int Manzana, int Lote, int Parcela, int Nivel, int Nro_titular)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT *FROM TITULARES_X_CEMENTERIO WHERE");
                sql.AppendLine("Tipo = @Tipo");
                sql.AppendLine("AND Manzana = @Manzana");
                sql.AppendLine("AND Lote = @Lote");
                sql.AppendLine("AND Parcela = @Parcela");
                sql.AppendLine("AND Nivel = @Nivel");
                sql.AppendLine("AND Nro_titular = @Nro_titular");
                TITULARES_X_CEMENTERIO obj = null;
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
                    cmd.Parameters.AddWithValue("@Nro_titular", Nro_titular);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<TITULARES_X_CEMENTERIO> lst = mapeo(dr);
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

        public static int insert(TITULARES_X_CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO TITULARES_X_CEMENTERIO(");
                sql.AppendLine("Tipo");
                sql.AppendLine(", Manzana");
                sql.AppendLine(", Lote");
                sql.AppendLine(", Parcela");
                sql.AppendLine(", Nivel");
                sql.AppendLine(", Nro_titular");
                sql.AppendLine(", Nom_titular");
                sql.AppendLine(", Cod_calle_dom_esp");
                sql.AppendLine(", Nom_calle_dom_esp");
                sql.AppendLine(", Cod_barrio_dom_esp");
                sql.AppendLine(", Nom_barrio_dom_esp");
                sql.AppendLine(", Nro_dom_esp");
                sql.AppendLine(", Piso_dpto_dom_esp");
                sql.AppendLine(", Ciudad_dom_esp");
                sql.AppendLine(", Provincia_dom_esp");
                sql.AppendLine(", Pais_dom_esp");
                sql.AppendLine(", Cod_postal_dom_esp");
                sql.AppendLine(", Fecha_cambio_domicilio");
                sql.AppendLine(", Cuit");
                sql.AppendLine(", Activo");
                sql.AppendLine(")");
                sql.AppendLine("VALUES");
                sql.AppendLine("(");
                sql.AppendLine("@Tipo");
                sql.AppendLine(", @Manzana");
                sql.AppendLine(", @Lote");
                sql.AppendLine(", @Parcela");
                sql.AppendLine(", @Nivel");
                sql.AppendLine(", @Nro_titular");
                sql.AppendLine(", @Nom_titular");
                sql.AppendLine(", @Cod_calle_dom_esp");
                sql.AppendLine(", @Nom_calle_dom_esp");
                sql.AppendLine(", @Cod_barrio_dom_esp");
                sql.AppendLine(", @Nom_barrio_dom_esp");
                sql.AppendLine(", @Nro_dom_esp");
                sql.AppendLine(", @Piso_dpto_dom_esp");
                sql.AppendLine(", @Ciudad_dom_esp");
                sql.AppendLine(", @Provincia_dom_esp");
                sql.AppendLine(", @Pais_dom_esp");
                sql.AppendLine(", @Cod_postal_dom_esp");
                sql.AppendLine(", @Fecha_cambio_domicilio");
                sql.AppendLine(", @Cuit");
                sql.AppendLine(", @Activo");
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
                    cmd.Parameters.AddWithValue("@Nro_titular", obj.nro_titular);
                    cmd.Parameters.AddWithValue("@Nom_titular", obj.nom_titular);
                    cmd.Parameters.AddWithValue("@Cod_calle_dom_esp", obj.cod_calle_dom_esp);
                    cmd.Parameters.AddWithValue("@Nom_calle_dom_esp", obj.nom_calle_dom_esp);
                    cmd.Parameters.AddWithValue("@Cod_barrio_dom_esp", obj.cod_barrio_dom_esp);
                    cmd.Parameters.AddWithValue("@Nom_barrio_dom_esp", obj.nom_barrio_dom_esp);
                    cmd.Parameters.AddWithValue("@Nro_dom_esp", obj.nro_dom_esp);
                    cmd.Parameters.AddWithValue("@Piso_dpto_dom_esp", obj.piso_dpto_dom_esp);
                    cmd.Parameters.AddWithValue("@Ciudad_dom_esp", obj.ciudad_dom_esp);
                    cmd.Parameters.AddWithValue("@Provincia_dom_esp", obj.provincia_dom_esp);
                    cmd.Parameters.AddWithValue("@Pais_dom_esp", obj.pais_dom_esp);
                    cmd.Parameters.AddWithValue("@Cod_postal_dom_esp", obj.cod_postal_dom_esp);
                    cmd.Parameters.AddWithValue("@Fecha_cambio_domicilio", obj.fecha_cambio_domicilio);
                    cmd.Parameters.AddWithValue("@Cuit", obj.cuit);
                    cmd.Parameters.AddWithValue("@Activo", obj.activo);
                    cmd.Connection.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(TITULARES_X_CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  TITULARES_X_CEMENTERIO SET");
                sql.AppendLine("Nom_titular=@Nom_titular");
                sql.AppendLine(", Cod_calle_dom_esp=@Cod_calle_dom_esp");
                sql.AppendLine(", Nom_calle_dom_esp=@Nom_calle_dom_esp");
                sql.AppendLine(", Cod_barrio_dom_esp=@Cod_barrio_dom_esp");
                sql.AppendLine(", Nom_barrio_dom_esp=@Nom_barrio_dom_esp");
                sql.AppendLine(", Nro_dom_esp=@Nro_dom_esp");
                sql.AppendLine(", Piso_dpto_dom_esp=@Piso_dpto_dom_esp");
                sql.AppendLine(", Ciudad_dom_esp=@Ciudad_dom_esp");
                sql.AppendLine(", Provincia_dom_esp=@Provincia_dom_esp");
                sql.AppendLine(", Pais_dom_esp=@Pais_dom_esp");
                sql.AppendLine(", Cod_postal_dom_esp=@Cod_postal_dom_esp");
                sql.AppendLine(", Fecha_cambio_domicilio=@Fecha_cambio_domicilio");
                sql.AppendLine(", Cuit=@Cuit");
                sql.AppendLine(", Activo=@Activo");
                sql.AppendLine("WHERE");
                sql.AppendLine("Tipo=@Tipo");
                sql.AppendLine("AND Manzana=@Manzana");
                sql.AppendLine("AND Lote=@Lote");
                sql.AppendLine("AND Parcela=@Parcela");
                sql.AppendLine("AND Nivel=@Nivel");
                sql.AppendLine("AND Nro_titular=@Nro_titular");
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
                    cmd.Parameters.AddWithValue("@Nro_titular", obj.nro_titular);
                    cmd.Parameters.AddWithValue("@Nom_titular", obj.nom_titular);
                    cmd.Parameters.AddWithValue("@Cod_calle_dom_esp", obj.cod_calle_dom_esp);
                    cmd.Parameters.AddWithValue("@Nom_calle_dom_esp", obj.nom_calle_dom_esp);
                    cmd.Parameters.AddWithValue("@Cod_barrio_dom_esp", obj.cod_barrio_dom_esp);
                    cmd.Parameters.AddWithValue("@Nom_barrio_dom_esp", obj.nom_barrio_dom_esp);
                    cmd.Parameters.AddWithValue("@Nro_dom_esp", obj.nro_dom_esp);
                    cmd.Parameters.AddWithValue("@Piso_dpto_dom_esp", obj.piso_dpto_dom_esp);
                    cmd.Parameters.AddWithValue("@Ciudad_dom_esp", obj.ciudad_dom_esp);
                    cmd.Parameters.AddWithValue("@Provincia_dom_esp", obj.provincia_dom_esp);
                    cmd.Parameters.AddWithValue("@Pais_dom_esp", obj.pais_dom_esp);
                    cmd.Parameters.AddWithValue("@Cod_postal_dom_esp", obj.cod_postal_dom_esp);
                    cmd.Parameters.AddWithValue("@Fecha_cambio_domicilio", obj.fecha_cambio_domicilio);
                    cmd.Parameters.AddWithValue("@Cuit", obj.cuit);
                    cmd.Parameters.AddWithValue("@Activo", obj.activo);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(TITULARES_X_CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE  TITULARES_X_CEMENTERIO ");
                sql.AppendLine("WHERE");
                sql.AppendLine("Tipo=@Tipo");
                sql.AppendLine("AND Manzana=@Manzana");
                sql.AppendLine("AND Lote=@Lote");
                sql.AppendLine("AND Parcela=@Parcela");
                sql.AppendLine("AND Nivel=@Nivel");
                sql.AppendLine("AND Nro_titular=@Nro_titular");
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
                    cmd.Parameters.AddWithValue("@Nro_titular", obj.nro_titular);
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

