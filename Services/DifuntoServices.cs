using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api_Cem.Entities;

namespace Web_Api_Cem.Services
{
    public class DifuntosServices : IDifuntosServices
    {
        public void delete(DIFUNTOS obj)
        {
            try
            {
                Entities.DIFUNTOS.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DIFUNTOS getByPk(char Tipo, int Manzana, int Lote, int Parcela, int Nivel)
        {
            try
            {
                return Entities.DIFUNTOS.getByPk(Tipo,Manzana,Lote,Parcela,Nivel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(DIFUNTOS obj)
        {
            try
            {
                return Entities.DIFUNTOS.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DIFUNTOS> read()
        {
            try
            {
                return Entities.DIFUNTOS.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DIFUNTOS> BuscarDifuntos(char Tipo, int Manzana, int Lote, int Parcela, int Nivel)
        {
            try
            {
                return Entities.DIFUNTOS.BuscarDifuntos(Tipo,Manzana, Lote, Parcela, Nivel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(DIFUNTOS obj)
        {
            try
            {
                Entities.DIFUNTOS.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
    }
}
