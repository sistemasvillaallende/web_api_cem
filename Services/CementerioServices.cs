using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api_Cem.Entities;

namespace Web_Api_Cem.Services
{
    public class Cementerioservices : ICementerioServices
    {
        public void delete(CEMENTERIO obj)
        {
            try
            {
                Entities.CEMENTERIO.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CEMENTERIO getByPk(char Tipo, int Manzana, int Lote, int Parcela, int Nivel)
        {
            try
            {
                return Entities.CEMENTERIO.getByPk(Tipo, Manzana, Lote, Parcela, Nivel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(CEMENTERIO obj)
        {
            try
            {
                return Entities.CEMENTERIO.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CEMENTERIO> read()
        {
            try
            {
                return Entities.CEMENTERIO.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(CEMENTERIO obj)
        {
            try
            {
                Entities.CEMENTERIO.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

