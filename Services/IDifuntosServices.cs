using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api_Cem.Services
{
    public interface IDifuntosServices
    {
        public int insert(Entities.DIFUNTOS obj);
        public void update(Entities.DIFUNTOS obj);
        public void delete(Entities.DIFUNTOS obj);
        public List<Entities.DIFUNTOS> read();
        public List<Entities.DIFUNTOS> BuscarDifuntos(char Tipo, int Manzana, int Lote, int Parcela, int Nivel);
        public Entities.DIFUNTOS getByPk(char Tipo, int Manzana, int Lote, int Parcela, int Nivel);

      
    }

   
}
