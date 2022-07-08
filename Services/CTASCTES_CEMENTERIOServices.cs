using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api_Cem.Entities;

namespace Web_Api_Cem.Services
{
    public class CTASCTES_CEMENTERIOServices:ICTASCTES_CEMENTERIOServices
    {
        public void delete(CTASCTES_CEMENTERIO obj)
        {
            try
            {
                Entities.CTASCTES_CEMENTERIO.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CTASCTES_CEMENTERIO getByPk(int Tipo_transaccion, int Nro_transaccion, int Nro_pago_parcial)
        {
            try
            {
                return Entities.CTASCTES_CEMENTERIO.getByPk(Tipo_transaccion, Nro_transaccion, Nro_pago_parcial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(CTASCTES_CEMENTERIO obj)
        {
            try
            {
                return Entities.CTASCTES_CEMENTERIO.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CATE_DEUDA_CEMENTERIO> ListarCategorias()
        {
            try
            {
                return Entities.CTASCTES_CEMENTERIO.ListarCategorias();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CTASCTES_CEMENTERIO> read()
        {
            try
            {
                return Entities.CTASCTES_CEMENTERIO.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CTASCTES_CEMENTERIO> List6arCtaCte(char Tipo, int Manzana, int Lote, int Parcela,
            int Nivel, int Tipo_consulta, int Categoria_desde, int Categoria_hasta)
        {
            try
            {
                return Entities.CTASCTES_CEMENTERIO.List6arCtaCte(Tipo, Manzana, Lote, Parcela, Nivel, Tipo_consulta, Categoria_desde, Categoria_hasta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(CTASCTES_CEMENTERIO obj)
        {
            try
            {
                Entities.CTASCTES_CEMENTERIO.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
