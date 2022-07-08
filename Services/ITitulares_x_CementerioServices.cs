using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api_Cem.Services
{
    public interface ITitulares_x_CementerioServices
    {
        public int insert(Entities.TITULARES_X_CEMENTERIO obj);
        public void update(Entities.TITULARES_X_CEMENTERIO obj);
        public void delete(Entities.TITULARES_X_CEMENTERIO obj);
        public List<Entities.TITULARES_X_CEMENTERIO> read();
        public List<Entities.TITULARES_X_CEMENTERIO> listarTitulares(char Tipo, int Manzana, int Lote, int Parcela,
         int Nivel);
        
            // public List<Entities.DIFUNTOS> BuscarDifuntos(char Tipo, int Manzana, int Lote, int Parcela, int Nivel);
            public Entities.TITULARES_X_CEMENTERIO getByPk(char Tipo, int Manzana, int Lote, int Parcela, int Nivel, int Nro_titular);

    }
}
