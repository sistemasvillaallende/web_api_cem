using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Web_Api_Cem.Entities
{
    public class CEMENTERIO : DALBase
    {
        public string tipo { get; set; }
        public int manzana { get; set; }
        public int lote { get; set; }
        public int parcela { get; set; }
        public int nivel { get; set; }
        public DateTime fecha_alta_registro { get; set; }
        public DateTime fecha_contrato { get; set; }
        public DateTime fecha_renovacion { get; set; }
        public string nro_contrato { get; set; }
        public int nro_titular_1 { get; set; }
        public string nom_titular1 { get; set; }
        public int nro_titular_2 { get; set; }
        public string nom_titular2 { get; set; }
        public bool unificado { get; set; }
        public bool exento { get; set; }
        public bool ocupado { get; set; }
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
        public string pri_periodo_liq { get; set; }
        public string ult_periodo_liq { get; set; }
        public bool emite_cedulon { get; set; }
        public string clave_pago { get; set; }
        public string cuit { get; set; }
        public string cuit_Vecino_Digital { get; set; }
        public Int16 cedulon_digital { get; set; }
        public DateTime fecha_vecino_digital { get; set; }
        public string identificacion { get; set; }

        public CEMENTERIO()
        {
            tipo = string.Empty;
            manzana = 0;
            lote = 0;
            parcela = 0;
            nivel = 0;
            fecha_alta_registro = DateTime.Now;
            fecha_contrato = DateTime.Now;
            fecha_renovacion = DateTime.Now;
            nro_contrato = string.Empty;
            nro_titular_1 = 0;
            nom_titular1 = string.Empty;
            nro_titular_2 = 0;
            nom_titular2 = string.Empty;
            unificado = false;
            exento = false;
            ocupado = false;
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
            pri_periodo_liq = string.Empty;
            ult_periodo_liq = string.Empty;
            emite_cedulon = false;
            clave_pago = string.Empty;
            cuit = string.Empty;
            cuit_Vecino_Digital = string.Empty;
            cedulon_digital = 0;
            fecha_vecino_digital = DateTime.Now;
            identificacion = string.Empty;
        }

        private static List<CEMENTERIO> mapeo(SqlDataReader dr)
        {
            List<CEMENTERIO> lst = new List<CEMENTERIO>();
            CEMENTERIO obj;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    obj = new CEMENTERIO();
                    if (!dr.IsDBNull(0)) { obj.tipo = dr.GetString(0); }
                    if (!dr.IsDBNull(1)) { obj.manzana = dr.GetInt32(1); }
                    if (!dr.IsDBNull(2)) { obj.lote = dr.GetInt32(2); }
                    if (!dr.IsDBNull(3)) { obj.parcela = dr.GetInt32(3); }
                    if (!dr.IsDBNull(4)) { obj.nivel = dr.GetInt32(4); }
                    if (!dr.IsDBNull(5)) { obj.fecha_alta_registro = dr.GetDateTime(5); }
                    if (!dr.IsDBNull(6)) { obj.fecha_contrato = dr.GetDateTime(6); }
                    if (!dr.IsDBNull(7)) { obj.fecha_renovacion = dr.GetDateTime(7); }
                    if (!dr.IsDBNull(8)) { obj.nro_contrato = dr.GetString(8); }
                    if (!dr.IsDBNull(9)) { obj.nro_titular_1 = dr.GetInt32(9); }
                    if (!dr.IsDBNull(10)) { obj.nom_titular1 = dr.GetString(10); }
                    if (!dr.IsDBNull(11)) { obj.nro_titular_2 = dr.GetInt32(11); }
                    if (!dr.IsDBNull(12)) { obj.nom_titular2 = dr.GetString(12); }
                    if (!dr.IsDBNull(13)) { obj.unificado = dr.GetBoolean(13); }
                    if (!dr.IsDBNull(14)) { obj.exento = dr.GetBoolean(14); }
                    if (!dr.IsDBNull(15)) { obj.ocupado = dr.GetBoolean(15); }
                    if (!dr.IsDBNull(16)) { obj.cod_calle_dom_esp = dr.GetInt32(16); }
                    if (!dr.IsDBNull(17)) { obj.nom_calle_dom_esp = dr.GetString(17); }
                    if (!dr.IsDBNull(18)) { obj.cod_barrio_dom_esp = dr.GetInt32(18); }
                    if (!dr.IsDBNull(19)) { obj.nom_barrio_dom_esp = dr.GetString(19); }
                    if (!dr.IsDBNull(20)) { obj.nro_dom_esp = dr.GetInt32(20); }
                    if (!dr.IsDBNull(21)) { obj.piso_dpto_dom_esp = dr.GetString(21); }
                    if (!dr.IsDBNull(22)) { obj.ciudad_dom_esp = dr.GetString(22); }
                    if (!dr.IsDBNull(23)) { obj.provincia_dom_esp = dr.GetString(23); }
                    if (!dr.IsDBNull(24)) { obj.pais_dom_esp = dr.GetString(24); }
                    if (!dr.IsDBNull(25)) { obj.cod_postal_dom_esp = dr.GetString(25); }
                    if (!dr.IsDBNull(26)) { obj.fecha_cambio_domicilio = dr.GetDateTime(26); }
                    if (!dr.IsDBNull(27)) { obj.pri_periodo_liq = dr.GetString(27); }
                    if (!dr.IsDBNull(28)) { obj.ult_periodo_liq = dr.GetString(28); }
                    if (!dr.IsDBNull(29)) { obj.emite_cedulon = dr.GetBoolean(29); }
                    if (!dr.IsDBNull(30)) { obj.clave_pago = dr.GetString(30); }
                    if (!dr.IsDBNull(31)) { obj.cuit = dr.GetString(31); }
                    if (!dr.IsDBNull(32)) { obj.cuit_Vecino_Digital = dr.GetString(32); }
                    if (!dr.IsDBNull(33)) { obj.cedulon_digital = dr.GetInt16(33); }
                    if (!dr.IsDBNull(34)) { obj.fecha_vecino_digital = dr.GetDateTime(34); }
                    if (!dr.IsDBNull(35)) { obj.identificacion = dr.GetString(35); }
                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<CEMENTERIO> read()
        {
            try
            {
                List<CEMENTERIO> lst = new List<CEMENTERIO>();
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT *," +
                        "  identificacion = TIPO+'-'+LTRIM(rtrim( CONVERT(char, Manzana) ))+'-'+LTRIM(rtrim( CONVERT(char, Lote) ))+'-'+LTRIM(rtrim( CONVERT(char, Parcela) ))+'-'+LTRIM(rtrim( CONVERT(char, Nivel) ))" +
                        "  FROM CEMENTERIO ";
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

        public static CEMENTERIO getByPk(
        char tipo, int manzana, int lote, int parcela, int nivel)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM CEMENTERIO WHERE ");
                sql.AppendLine("Tipo = @Tipo");
                sql.AppendLine("AND Manzana = @Manzana");
                sql.AppendLine("AND Lote = @Lote");
                sql.AppendLine("AND Parcela = @Parcela");
                sql.AppendLine("AND Nivel = @Nivel");
                CEMENTERIO obj = null;
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Manzana", manzana);
                    cmd.Parameters.AddWithValue("@Lote", lote);
                    cmd.Parameters.AddWithValue("@Parcela", parcela);
                    cmd.Parameters.AddWithValue("@Nivel", nivel);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<CEMENTERIO> lst = mapeo(dr);
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

        public static int insert(CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO CEMENTERIO(");
                sql.AppendLine("Tipo");
                sql.AppendLine(", Manzana");
                sql.AppendLine(", Lote");
                sql.AppendLine(", Parcela");
                sql.AppendLine(", Nivel");
                sql.AppendLine(", Fecha_alta_registro");
                sql.AppendLine(", Fecha_contrato");
                sql.AppendLine(", Fecha_renovacion");
                sql.AppendLine(", Nro_contrato");
                sql.AppendLine(", Nro_titular_1");
                sql.AppendLine(", Nom_titular1");
                sql.AppendLine(", Nro_titular_2");
                sql.AppendLine(", Nom_titular2");
                sql.AppendLine(", Unificado");
                sql.AppendLine(", Exento");
                sql.AppendLine(", Ocupado");
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
                sql.AppendLine(", Pri_periodo_liq");
                sql.AppendLine(", Ult_periodo_liq");
                sql.AppendLine(", Emite_cedulon");
                sql.AppendLine(", Clave_pago");
                sql.AppendLine(", Cuit");
                sql.AppendLine(", Cuit_Vecino_Digital");
                sql.AppendLine(", cedulon_digital");
                sql.AppendLine(", fecha_vecino_digital");
                sql.AppendLine(")");
                sql.AppendLine("VALUES");
                sql.AppendLine("(");
                sql.AppendLine("@Tipo");
                sql.AppendLine(", @Manzana");
                sql.AppendLine(", @Lote");
                sql.AppendLine(", @Parcela");
                sql.AppendLine(", @Nivel");
                sql.AppendLine(", @Fecha_alta_registro");
                sql.AppendLine(", @Fecha_contrato");
                sql.AppendLine(", @Fecha_renovacion");
                sql.AppendLine(", @Nro_contrato");
                sql.AppendLine(", @Nro_titular_1");
                sql.AppendLine(", @Nom_titular1");
                sql.AppendLine(", @Nro_titular_2");
                sql.AppendLine(", @Nom_titular2");
                sql.AppendLine(", @Unificado");
                sql.AppendLine(", @Exento");
                sql.AppendLine(", @Ocupado");
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
                sql.AppendLine(", @Pri_periodo_liq");
                sql.AppendLine(", @Ult_periodo_liq");
                sql.AppendLine(", @Emite_cedulon");
                sql.AppendLine(", @Clave_pago");
                sql.AppendLine(", @Cuit");
                sql.AppendLine(", @Cuit_Vecino_Digital");
                sql.AppendLine(", @cedulon_digital");
                sql.AppendLine(", @fecha_vecino_digital");
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
                    cmd.Parameters.AddWithValue("@Fecha_contrato", obj.fecha_contrato);
                    cmd.Parameters.AddWithValue("@Fecha_renovacion", obj.fecha_renovacion);
                    cmd.Parameters.AddWithValue("@Nro_contrato", obj.nro_contrato);
                    cmd.Parameters.AddWithValue("@Nro_titular_1", obj.nro_titular_1);
                    cmd.Parameters.AddWithValue("@Nom_titular1", obj.nom_titular1);
                    cmd.Parameters.AddWithValue("@Nro_titular_2", obj.nro_titular_2);
                    cmd.Parameters.AddWithValue("@Nom_titular2", obj.nom_titular2);
                    cmd.Parameters.AddWithValue("@Unificado", obj.unificado);
                    cmd.Parameters.AddWithValue("@Exento", obj.exento);
                    cmd.Parameters.AddWithValue("@Ocupado", obj.ocupado);
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
                    cmd.Parameters.AddWithValue("@Pri_periodo_liq", obj.pri_periodo_liq);
                    cmd.Parameters.AddWithValue("@Ult_periodo_liq", obj.ult_periodo_liq);
                    cmd.Parameters.AddWithValue("@Emite_cedulon", obj.emite_cedulon);
                    cmd.Parameters.AddWithValue("@Clave_pago", obj.clave_pago);
                    cmd.Parameters.AddWithValue("@Cuit", obj.cuit);
                    cmd.Parameters.AddWithValue("@Cuit_Vecino_Digital", obj.cuit_Vecino_Digital);
                    cmd.Parameters.AddWithValue("@cedulon_digital", obj.cedulon_digital);
                    cmd.Parameters.AddWithValue("@fecha_vecino_digital", obj.fecha_vecino_digital);
                    cmd.Connection.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  CEMENTERIO SET ");
                sql.AppendLine("  Fecha_alta_registro=@Fecha_alta_registro");
                sql.AppendLine(", Fecha_contrato=@Fecha_contrato");
                sql.AppendLine(", Fecha_renovacion=@Fecha_renovacion");
                sql.AppendLine(", Nro_contrato=@Nro_contrato");
                sql.AppendLine(", Nro_titular_1=@Nro_titular_1");
                sql.AppendLine(", Nom_titular1=@Nom_titular1");
                sql.AppendLine(", Nro_titular_2=@Nro_titular_2");
                sql.AppendLine(", Nom_titular2=@Nom_titular2");
                sql.AppendLine(", Unificado=@Unificado");
                sql.AppendLine(", Exento=@Exento");
                sql.AppendLine(", Ocupado=@Ocupado");
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
                sql.AppendLine(", Pri_periodo_liq=@Pri_periodo_liq");
                sql.AppendLine(", Ult_periodo_liq=@Ult_periodo_liq");
                sql.AppendLine(", Emite_cedulon=@Emite_cedulon");
                sql.AppendLine(", Clave_pago=@Clave_pago");
                sql.AppendLine(", Cuit=@Cuit");
                sql.AppendLine(", Cuit_Vecino_Digital=@Cuit_Vecino_Digital");
                sql.AppendLine(", cedulon_digital=@cedulon_digital");
                sql.AppendLine(", fecha_vecino_digital=@fecha_vecino_digital ");
                sql.AppendLine("WHERE");
                sql.AppendLine(" Tipo=@Tipo");
                sql.AppendLine(" AND Manzana=@Manzana");
                sql.AppendLine(" AND Lote=@Lote");
                sql.AppendLine(" AND Parcela=@Parcela");
                sql.AppendLine(" AND Nivel=@Nivel");
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
                    cmd.Parameters.AddWithValue("@Fecha_contrato", obj.fecha_contrato);
                    cmd.Parameters.AddWithValue("@Fecha_renovacion", obj.fecha_renovacion);
                    cmd.Parameters.AddWithValue("@Nro_contrato", obj.nro_contrato);
                    cmd.Parameters.AddWithValue("@Nro_titular_1", obj.nro_titular_1);
                    cmd.Parameters.AddWithValue("@Nom_titular1", obj.nom_titular1);
                    cmd.Parameters.AddWithValue("@Nro_titular_2", obj.nro_titular_2);
                    cmd.Parameters.AddWithValue("@Nom_titular2", obj.nom_titular2);
                    cmd.Parameters.AddWithValue("@Unificado", obj.unificado);
                    cmd.Parameters.AddWithValue("@Exento", obj.exento);
                    cmd.Parameters.AddWithValue("@Ocupado", obj.ocupado);
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
                    cmd.Parameters.AddWithValue("@Pri_periodo_liq", obj.pri_periodo_liq);
                    cmd.Parameters.AddWithValue("@Ult_periodo_liq", obj.ult_periodo_liq);
                    cmd.Parameters.AddWithValue("@Emite_cedulon", obj.emite_cedulon);
                    cmd.Parameters.AddWithValue("@Clave_pago", obj.clave_pago);
                    cmd.Parameters.AddWithValue("@Cuit", obj.cuit);
                    cmd.Parameters.AddWithValue("@Cuit_Vecino_Digital", obj.cuit_Vecino_Digital);
                    cmd.Parameters.AddWithValue("@cedulon_digital", obj.cedulon_digital);
                    cmd.Parameters.AddWithValue("@fecha_vecino_digital", obj.fecha_vecino_digital);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE  CEMENTERIO ");
                sql.AppendLine("WHERE ");
                sql.AppendLine("Tipo=@Tipo");
                sql.AppendLine("AND Manzana=@Manzana");
                sql.AppendLine("AND Lote=@Lote");
                sql.AppendLine("AND Parcela=@Parcela");
                sql.AppendLine("AND Nivel=@Nivel");
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

