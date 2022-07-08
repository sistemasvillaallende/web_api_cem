using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api_Cem.Entities;
namespace Web_Api_Cem.Services
{
    public class Titulares_x_CementerioServices:ITitulares_x_CementerioServices
    {
        public void delete(TITULARES_X_CEMENTERIO obj)
        {
            try
            {
                Entities.TITULARES_X_CEMENTERIO.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TITULARES_X_CEMENTERIO getByPk(char Tipo, int Manzana, int Lote, int Parcela, int Nivel, int Nro_titular)
        {
            try
            {
                return Entities.TITULARES_X_CEMENTERIO.getByPk(Tipo, Manzana, Lote, Parcela, Nivel,Nro_titular);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(TITULARES_X_CEMENTERIO obj)
        {
            try
            {
                return Entities.TITULARES_X_CEMENTERIO.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TITULARES_X_CEMENTERIO> read()
        {
            try
            {
                return Entities.TITULARES_X_CEMENTERIO.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TITULARES_X_CEMENTERIO> listarTitulares(char Tipo, int Manzana, int Lote, int Parcela,
           int Nivel)
        {
            try
            {
                return Entities.TITULARES_X_CEMENTERIO.listarTitulares(Tipo,Manzana,Lote,Parcela,Nivel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            //public List<TITULARES_X_CEMENTERIO> BuscarDifuntos(char Tipo, int Manzana, int Lote, int Parcela, int Nivel)
            //{
            //    try
            //    {
            //        return Entities.DIFUNTOS.BuscarDifuntos(Tipo, Manzana, Lote, Parcela, Nivel);
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
            public void update(TITULARES_X_CEMENTERIO obj)
        {
            try
            {
                Entities.TITULARES_X_CEMENTERIO.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
