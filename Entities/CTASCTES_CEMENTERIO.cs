using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Web_Api_Cem.Entities
{
    public class CTASCTES_CEMENTERIO : DALBase
    {
        public int tipo_transaccion { get; set; }
        public int rro_transaccion { get; set; }
        public int nro_pago_parcial { get; set; }
        public DateTime fecha_transaccion { get; set; }
        public string tipo { get; set; }
        public int manzana { get; set; }
        public int lote { get; set; }
        public int parcela { get; set; }
        public int nivel { get; set; }
        public string periodo { get; set; }
        public bool cedulon_impreso { get; set; }
        public bool pago_parcial { get; set; }
        public bool pagado { get; set; }
        public decimal monto_original { get; set; }
        public decimal debe { get; set; }
        public decimal haber { get; set; }
        public DateTime vencimiento { get; set; }
        public bool deuda_activa { get; set; }
        public int nro_plan { get; set; }
        public int nro_procuracion { get; set; }
        public int categoria_deuda { get; set; }
        public decimal monto_pagado { get; set; }
        public int nro_cedulon { get; set; }
        public decimal recargo { get; set; }
        public decimal honorarios { get; set; }
        public decimal iva_hons { get; set; }
        public Int16 tipo_deuda { get; set; }
        public string decreto { get; set; }
        public string observaciones { get; set; }
        public Int64 nro_cedulon_paypertic { get; set; }
        public string movim { get; set; }
        public string categoria { get; set; }

        public CTASCTES_CEMENTERIO()
        {
            tipo_transaccion = 0;
            rro_transaccion = 0;
            nro_pago_parcial = 0;
            fecha_transaccion = DateTime.Now;
            tipo = string.Empty;
            manzana = 0;
            lote = 0;
            parcela = 0;
            nivel = 0;
            periodo = string.Empty;
            cedulon_impreso = false;
            pago_parcial = false;
            pagado = false;
            monto_original = 0;
            debe = 0;
            haber = 0;
            vencimiento = DateTime.Now;
            deuda_activa = false;
            nro_plan = 0;
            nro_procuracion = 0;
            categoria_deuda = 0;
            monto_pagado = 0;
            nro_cedulon = 0;
            recargo = 0;
            honorarios = 0;
            iva_hons = 0;
            tipo_deuda = 0;
            decreto = string.Empty;
            observaciones = string.Empty;
            nro_cedulon_paypertic = 0;
            movim = string.Empty;
            categoria = string.Empty;
        }

        private static List<CTASCTES_CEMENTERIO> mapeo(SqlDataReader dr)
        {
            List<CTASCTES_CEMENTERIO> lst = new List<CTASCTES_CEMENTERIO>();
            CTASCTES_CEMENTERIO obj;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    obj = new CTASCTES_CEMENTERIO();
                    if (!dr.IsDBNull(0)) { obj.tipo_transaccion = dr.GetInt32(0); }
                    if (!dr.IsDBNull(1)) { obj.rro_transaccion = dr.GetInt32(1); }
                    if (!dr.IsDBNull(2)) { obj.nro_pago_parcial = dr.GetInt32(2); }
                    if (!dr.IsDBNull(3)) { obj.fecha_transaccion = dr.GetDateTime(3); }
                    if (!dr.IsDBNull(4)) { obj.tipo = dr.GetString(4); }
                    if (!dr.IsDBNull(5)) { obj.manzana = dr.GetInt32(5); }
                    if (!dr.IsDBNull(6)) { obj.lote = dr.GetInt32(6); }
                    if (!dr.IsDBNull(7)) { obj.parcela = dr.GetInt32(7); }
                    if (!dr.IsDBNull(8)) { obj.nivel = dr.GetInt32(8); }
                    if (!dr.IsDBNull(9)) { obj.periodo = dr.GetString(9); }
                    if (!dr.IsDBNull(10)) { obj.cedulon_impreso = dr.GetBoolean(10); }
                    if (!dr.IsDBNull(11)) { obj.pago_parcial = dr.GetBoolean(11); }
                    if (!dr.IsDBNull(12)) { obj.pagado = dr.GetBoolean(12); }
                    if (!dr.IsDBNull(13)) { obj.monto_original = dr.GetDecimal(13); }
                    if (!dr.IsDBNull(14)) { obj.debe = dr.GetDecimal(14); }
                    if (!dr.IsDBNull(15)) { obj.haber = dr.GetDecimal(15); }
                    if (!dr.IsDBNull(16)) { obj.vencimiento = dr.GetDateTime(16); }
                    if (!dr.IsDBNull(17)) { obj.deuda_activa = dr.GetBoolean(17); }
                    if (!dr.IsDBNull(18)) { obj.nro_plan = dr.GetInt32(18); }
                    if (!dr.IsDBNull(19)) { obj.nro_procuracion = dr.GetInt32(19); }
                    if (!dr.IsDBNull(20)) { obj.categoria_deuda = dr.GetInt32(20); }
                    if (!dr.IsDBNull(21)) { obj.monto_pagado = dr.GetDecimal(21); }
                    if (!dr.IsDBNull(22)) { obj.nro_cedulon = dr.GetInt32(22); }
                    if (!dr.IsDBNull(23)) { obj.recargo = dr.GetDecimal(23); }
                    if (!dr.IsDBNull(24)) { obj.honorarios = dr.GetDecimal(24); }
                    if (!dr.IsDBNull(25)) { obj.iva_hons = dr.GetDecimal(25); }
                    if (!dr.IsDBNull(26)) { obj.tipo_deuda = dr.GetInt16(26); }
                    if (!dr.IsDBNull(27)) { obj.decreto = dr.GetString(27); }
                    if (!dr.IsDBNull(28)) { obj.observaciones = dr.GetString(28); }
                    if (!dr.IsDBNull(29)) { obj.nro_cedulon_paypertic = dr.GetInt64(29); }
                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<CTASCTES_CEMENTERIO> List6arCtaCte(char Tipo, int Manzana, int Lote, int Parcela, 
            int Nivel, int Tipo_consulta,int Categoria_desde,int Categoria_hasta)
        {
            try
            {
                List<CTASCTES_CEMENTERIO> lst = new List<CTASCTES_CEMENTERIO>();
                using (SqlConnection con = getConnection())
                {
                    StringBuilder sql = new StringBuilder();
                    
                   if (Tipo_consulta==0)// toda la cuenta corriente
                    {
                        sql.AppendLine(" SELECT movim=(select t.Descripcion from TIPOS_TRANSACCIONES t ");
                        sql.AppendLine("                where t.tipo_transaccion=a.Tipo_transaccion) , ");
                        sql.AppendLine(" a.periodo, a.Monto_original, a.Debe, a.Haber, a.Nro_plan, a.Nro_procuracion,");
                        sql.AppendLine(" categoria = (select c.des_categoria from CATE_DEUDA_CEMENTERIO c");
                        sql.AppendLine("              where c.cod_categoria = a.Categoria_deuda ) ");
                        sql.AppendLine(" FROM CTASCTES_CEMENTERIO A WITH (NOLOCK) ");
                        sql.AppendLine("  WHERE  " );
                        sql.AppendLine("   A.tipo =@tipo AND  ");
                        sql.AppendLine("   A.manzana =@manzana AND ");
                        sql.AppendLine("   A.lote =@lote AND  ");
                        sql.AppendLine("   A.parcela = @parcela AND  ");
                        sql.AppendLine("   A.nivel =@nivel AND  ");
                        sql.AppendLine("   A.deuda_activa = 1 AND  ");
                        if (Categoria_desde==Categoria_hasta)
                        {
                            sql.AppendLine("   A.categoria_deuda= @categoria_desde  ");
                        }
                        else
                        {
                            sql.AppendLine("   A.categoria_deuda between @categoria_desde and @categoria_hasta ");
                        }
                        sql.AppendLine(" ORDER BY A.vencimiento, A.periodo, A.nro_transaccion, A.tipo_transaccion ");

                    }
                    else  // solo deudas
                    {
                        sql.AppendLine(" SELECT movim=(select t.Descripcion from TIPOS_TRANSACCIONES t");
                        sql.AppendLine("                where t.tipo_transaccion=a.Tipo_transaccion) , ");
                        sql.AppendLine(" a.periodo, a.Monto_original, a.Debe, a.Haber, a.Nro_plan, a.Nro_procuracion,");
                        sql.AppendLine(" categoria = (select c.des_categoria from CATE_DEUDA_CEMENTERIO c");
                        sql.AppendLine("              where c.cod_categoria = a.Categoria_deuda ) ");
                        sql.AppendLine(" FROM CTASCTES_CEMENTERIO A WITH (NOLOCK) ");
                        sql.AppendLine("  WHERE  ");
                        sql.AppendLine("   A.tipo =@tipo AND  ");
                        sql.AppendLine("   A.manzana =@manzana AND ");
                        sql.AppendLine("   A.lote =@lote AND  ");
                        sql.AppendLine("   A.parcela = @parcela AND  ");
                        sql.AppendLine("   A.nivel =@nivel AND  ");
                        sql.AppendLine("   A.deuda_activa = 1 AND  ");
                        if (Categoria_desde == Categoria_hasta)
                        {
                            sql.AppendLine("   A.categoria_deuda= @categoria_desde  ");
                        }
                        else
                        {
                            sql.AppendLine("   A.categoria_deuda between @categoria_desde and @categoria_hasta ");
                        }

                        sql.AppendLine("  AND ((A.tipo_transaccion=1 AND A.pagado=0) OR  ");
                        sql.AppendLine("       (A.tipo_transaccion <> 1 AND NOT EXISTS(SELECT * FROM CTASCTES_CEMENTERIO B ");
                        sql.AppendLine("     WHERE B.tipo_transaccion = 1 AND B.nro_transaccion = A.nro_transaccion AND pagado = 1))) ");
                        sql.AppendLine(" ORDER BY A.vencimiento, A.periodo, A.nro_transaccion, A.tipo_transaccion ");
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@tipo", Tipo);
                    cmd.Parameters.AddWithValue("@manzana", Manzana);
                    cmd.Parameters.AddWithValue("@lote", Lote);
                    cmd.Parameters.AddWithValue("@parcela", Parcela);
                    cmd.Parameters.AddWithValue("@nivel", Nivel);
                    cmd.Parameters.AddWithValue("@categoria_desde", Categoria_desde);
                    cmd.Parameters.AddWithValue("@categoria_hasta", Categoria_hasta);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    //lst = mapeo(dr);
                    //List<CTASCTES_CEMENTERIO> lst = new List<CTASCTES_CEMENTERIO>();
                    CTASCTES_CEMENTERIO obj;
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            obj = new CTASCTES_CEMENTERIO();
                            if (!dr.IsDBNull(0)) { obj.movim = dr.GetString(0); }
                            if (!dr.IsDBNull(1)) { obj.periodo = dr.GetString(1); }
                            if (!dr.IsDBNull(2)) { obj.monto_original = dr.GetDecimal(2); }
                            if (!dr.IsDBNull(3)) { obj.debe = dr.GetDecimal(3); }
                            if (!dr.IsDBNull(4)) { obj.haber = dr.GetDecimal(4); }
                            if (!dr.IsDBNull(5)) { obj.nro_plan = dr.GetInt32(5); }
                            if (!dr.IsDBNull(6)) { obj.nro_procuracion = dr.GetInt32(6); }
                            if (!dr.IsDBNull(7)) { obj.categoria= dr.GetString(7); }       
                            lst.Add(obj);
                        }
                    }

                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<CTASCTES_CEMENTERIO> read()
        {
            try
            {
                List<CTASCTES_CEMENTERIO> lst = new List<CTASCTES_CEMENTERIO>();
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT *FROM CTASCTES_CEMENTERIO";
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
        public static List<CATE_DEUDA_CEMENTERIO> ListarCategorias()
        {
            try
            {
                List<CATE_DEUDA_CEMENTERIO> lst = new List<CATE_DEUDA_CEMENTERIO>();
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM CATE_DEUDA_CEMENTERIO";
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    CATE_DEUDA_CEMENTERIO obj;
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            obj = new CATE_DEUDA_CEMENTERIO();
                            if (!dr.IsDBNull(0)) { obj.cod_categoria = dr.GetInt32(0); }
                            if (!dr.IsDBNull(1)) { obj.des_categoria = dr.GetString(1); }

                            lst.Add(obj);
                        }
                    }
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static CTASCTES_CEMENTERIO getByPk(
int Tipo_transaccion, int Nro_transaccion, int Nro_pago_parcial)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT *FROM CTASCTES_CEMENTERIO WHERE");
                sql.AppendLine("Tipo_transaccion = @Tipo_transaccion");
                sql.AppendLine("AND Nro_transaccion = @Nro_transaccion");
                sql.AppendLine("AND Nro_pago_parcial = @Nro_pago_parcial");
                CTASCTES_CEMENTERIO obj = null;
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo_transaccion", Tipo_transaccion);
                    cmd.Parameters.AddWithValue("@Nro_transaccion", Nro_transaccion);
                    cmd.Parameters.AddWithValue("@Nro_pago_parcial", Nro_pago_parcial);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<CTASCTES_CEMENTERIO> lst = mapeo(dr);
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

        public static int insert(CTASCTES_CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO CTASCTES_CEMENTERIO(");
                sql.AppendLine("Tipo_transaccion");
                sql.AppendLine(", Nro_transaccion");
                sql.AppendLine(", Nro_pago_parcial");
                sql.AppendLine(", Fecha_transaccion");
                sql.AppendLine(", Tipo");
                sql.AppendLine(", Manzana");
                sql.AppendLine(", Lote");
                sql.AppendLine(", Parcela");
                sql.AppendLine(", Nivel");
                sql.AppendLine(", Periodo");
                sql.AppendLine(", Cedulon_impreso");
                sql.AppendLine(", Pago_parcial");
                sql.AppendLine(", Pagado");
                sql.AppendLine(", Monto_original");
                sql.AppendLine(", Debe");
                sql.AppendLine(", Haber");
                sql.AppendLine(", Vencimiento");
                sql.AppendLine(", Deuda_activa");
                sql.AppendLine(", Nro_plan");
                sql.AppendLine(", Nro_procuracion");
                sql.AppendLine(", Categoria_deuda");
                sql.AppendLine(", Monto_pagado");
                sql.AppendLine(", Nro_cedulon");
                sql.AppendLine(", recargo");
                sql.AppendLine(", honorarios");
                sql.AppendLine(", iva_hons");
                sql.AppendLine(", tipo_deuda");
                sql.AppendLine(", decreto");
                sql.AppendLine(", observaciones");
                sql.AppendLine(", nro_cedulon_paypertic");
                sql.AppendLine(")");
                sql.AppendLine("VALUES");
                sql.AppendLine("(");
                sql.AppendLine("@Tipo_transaccion");
                sql.AppendLine(", @Nro_transaccion");
                sql.AppendLine(", @Nro_pago_parcial");
                sql.AppendLine(", @Fecha_transaccion");
                sql.AppendLine(", @Tipo");
                sql.AppendLine(", @Manzana");
                sql.AppendLine(", @Lote");
                sql.AppendLine(", @Parcela");
                sql.AppendLine(", @Nivel");
                sql.AppendLine(", @Periodo");
                sql.AppendLine(", @Cedulon_impreso");
                sql.AppendLine(", @Pago_parcial");
                sql.AppendLine(", @Pagado");
                sql.AppendLine(", @Monto_original");
                sql.AppendLine(", @Debe");
                sql.AppendLine(", @Haber");
                sql.AppendLine(", @Vencimiento");
                sql.AppendLine(", @Deuda_activa");
                sql.AppendLine(", @Nro_plan");
                sql.AppendLine(", @Nro_procuracion");
                sql.AppendLine(", @Categoria_deuda");
                sql.AppendLine(", @Monto_pagado");
                sql.AppendLine(", @Nro_cedulon");
                sql.AppendLine(", @recargo");
                sql.AppendLine(", @honorarios");
                sql.AppendLine(", @iva_hons");
                sql.AppendLine(", @tipo_deuda");
                sql.AppendLine(", @decreto");
                sql.AppendLine(", @observaciones");
                sql.AppendLine(", @nro_cedulon_paypertic");
                sql.AppendLine(")");
                sql.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo_transaccion", obj.tipo_transaccion);
                    cmd.Parameters.AddWithValue("@Nro_transaccion", obj.rro_transaccion);
                    cmd.Parameters.AddWithValue("@Nro_pago_parcial", obj.nro_pago_parcial);
                    cmd.Parameters.AddWithValue("@Fecha_transaccion", obj.fecha_transaccion);
                    cmd.Parameters.AddWithValue("@Tipo", obj.tipo);
                    cmd.Parameters.AddWithValue("@Manzana", obj.manzana);
                    cmd.Parameters.AddWithValue("@Lote", obj.lote);
                    cmd.Parameters.AddWithValue("@Parcela", obj.parcela);
                    cmd.Parameters.AddWithValue("@Nivel", obj.nivel);
                    cmd.Parameters.AddWithValue("@Periodo", obj.periodo);
                    cmd.Parameters.AddWithValue("@Cedulon_impreso", obj.cedulon_impreso);
                    cmd.Parameters.AddWithValue("@Pago_parcial", obj.pago_parcial);
                    cmd.Parameters.AddWithValue("@Pagado", obj.pagado);
                    cmd.Parameters.AddWithValue("@Monto_original", obj.monto_original);
                    cmd.Parameters.AddWithValue("@Debe", obj.debe);
                    cmd.Parameters.AddWithValue("@Haber", obj.haber);
                    cmd.Parameters.AddWithValue("@Vencimiento", obj.vencimiento);
                    cmd.Parameters.AddWithValue("@Deuda_activa", obj.deuda_activa);
                    cmd.Parameters.AddWithValue("@Nro_plan", obj.nro_plan);
                    cmd.Parameters.AddWithValue("@Nro_procuracion", obj.nro_procuracion);
                    cmd.Parameters.AddWithValue("@Categoria_deuda", obj.categoria_deuda);
                    cmd.Parameters.AddWithValue("@Monto_pagado", obj.monto_pagado);
                    cmd.Parameters.AddWithValue("@Nro_cedulon", obj.nro_cedulon);
                    cmd.Parameters.AddWithValue("@recargo", obj.recargo);
                    cmd.Parameters.AddWithValue("@honorarios", obj.honorarios);
                    cmd.Parameters.AddWithValue("@iva_hons", obj.iva_hons);
                    cmd.Parameters.AddWithValue("@tipo_deuda", obj.tipo_deuda);
                    cmd.Parameters.AddWithValue("@decreto", obj.decreto);
                    cmd.Parameters.AddWithValue("@observaciones", obj.observaciones);
                    cmd.Parameters.AddWithValue("@nro_cedulon_paypertic", obj.nro_cedulon_paypertic);
                    cmd.Connection.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(CTASCTES_CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  CTASCTES_CEMENTERIO SET");
                sql.AppendLine("Fecha_transaccion=@Fecha_transaccion");
                sql.AppendLine(", Tipo=@Tipo");
                sql.AppendLine(", Manzana=@Manzana");
                sql.AppendLine(", Lote=@Lote");
                sql.AppendLine(", Parcela=@Parcela");
                sql.AppendLine(", Nivel=@Nivel");
                sql.AppendLine(", Periodo=@Periodo");
                sql.AppendLine(", Cedulon_impreso=@Cedulon_impreso");
                sql.AppendLine(", Pago_parcial=@Pago_parcial");
                sql.AppendLine(", Pagado=@Pagado");
                sql.AppendLine(", Monto_original=@Monto_original");
                sql.AppendLine(", Debe=@Debe");
                sql.AppendLine(", Haber=@Haber");
                sql.AppendLine(", Vencimiento=@Vencimiento");
                sql.AppendLine(", Deuda_activa=@Deuda_activa");
                sql.AppendLine(", Nro_plan=@Nro_plan");
                sql.AppendLine(", Nro_procuracion=@Nro_procuracion");
                sql.AppendLine(", Categoria_deuda=@Categoria_deuda");
                sql.AppendLine(", Monto_pagado=@Monto_pagado");
                sql.AppendLine(", Nro_cedulon=@Nro_cedulon");
                sql.AppendLine(", recargo=@recargo");
                sql.AppendLine(", honorarios=@honorarios");
                sql.AppendLine(", iva_hons=@iva_hons");
                sql.AppendLine(", tipo_deuda=@tipo_deuda");
                sql.AppendLine(", decreto=@decreto");
                sql.AppendLine(", observaciones=@observaciones");
                sql.AppendLine(", nro_cedulon_paypertic=@nro_cedulon_paypertic");
                sql.AppendLine("WHERE");
                sql.AppendLine("Tipo_transaccion=@Tipo_transaccion");
                sql.AppendLine("AND Nro_transaccion=@Nro_transaccion");
                sql.AppendLine("AND Nro_pago_parcial=@Nro_pago_parcial");
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo_transaccion", obj.tipo_transaccion);
                    cmd.Parameters.AddWithValue("@Nro_transaccion", obj.rro_transaccion);
                    cmd.Parameters.AddWithValue("@Nro_pago_parcial", obj.nro_pago_parcial);
                    cmd.Parameters.AddWithValue("@Fecha_transaccion", obj.fecha_transaccion);
                    cmd.Parameters.AddWithValue("@Tipo", obj.tipo);
                    cmd.Parameters.AddWithValue("@Manzana", obj.manzana);
                    cmd.Parameters.AddWithValue("@Lote", obj.lote);
                    cmd.Parameters.AddWithValue("@Parcela", obj.parcela);
                    cmd.Parameters.AddWithValue("@Nivel", obj.nivel);
                    cmd.Parameters.AddWithValue("@Periodo", obj.periodo);
                    cmd.Parameters.AddWithValue("@Cedulon_impreso", obj.cedulon_impreso);
                    cmd.Parameters.AddWithValue("@Pago_parcial", obj.pago_parcial);
                    cmd.Parameters.AddWithValue("@Pagado", obj.pagado);
                    cmd.Parameters.AddWithValue("@Monto_original", obj.monto_original);
                    cmd.Parameters.AddWithValue("@Debe", obj.debe);
                    cmd.Parameters.AddWithValue("@Haber", obj.haber);
                    cmd.Parameters.AddWithValue("@Vencimiento", obj.vencimiento);
                    cmd.Parameters.AddWithValue("@Deuda_activa", obj.deuda_activa);
                    cmd.Parameters.AddWithValue("@Nro_plan", obj.nro_plan);
                    cmd.Parameters.AddWithValue("@Nro_procuracion", obj.nro_procuracion);
                    cmd.Parameters.AddWithValue("@Categoria_deuda", obj.categoria_deuda);
                    cmd.Parameters.AddWithValue("@Monto_pagado", obj.monto_pagado);
                    cmd.Parameters.AddWithValue("@Nro_cedulon", obj.nro_cedulon);
                    cmd.Parameters.AddWithValue("@recargo", obj.recargo);
                    cmd.Parameters.AddWithValue("@honorarios", obj.honorarios);
                    cmd.Parameters.AddWithValue("@iva_hons", obj.iva_hons);
                    cmd.Parameters.AddWithValue("@tipo_deuda", obj.tipo_deuda);
                    cmd.Parameters.AddWithValue("@decreto", obj.decreto);
                    cmd.Parameters.AddWithValue("@observaciones", obj.observaciones);
                    cmd.Parameters.AddWithValue("@nro_cedulon_paypertic", obj.nro_cedulon_paypertic);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(CTASCTES_CEMENTERIO obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE from  CTASCTES_CEMENTERIO ");
                sql.AppendLine("WHERE");
                sql.AppendLine("Tipo_transaccion=@Tipo_transaccion");
                sql.AppendLine("AND Nro_transaccion=@Nro_transaccion");
                sql.AppendLine("AND Nro_pago_parcial=@Nro_pago_parcial");
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Tipo_transaccion", obj.tipo_transaccion);
                    cmd.Parameters.AddWithValue("@Nro_transaccion", obj.rro_transaccion);
                    cmd.Parameters.AddWithValue("@Nro_pago_parcial", obj.nro_pago_parcial);
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

