using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api_Cem.Services
{
    public interface ICementerioServices
    {
        public int insert(Entities.CEMENTERIO obj);
        public void update(Entities.CEMENTERIO obj);
        public void delete(Entities.CEMENTERIO obj);
        public List<Entities.CEMENTERIO> read();
        public Entities.CEMENTERIO getByPk(char tipo, int manzana, int lote, int parcela, int nivel);


    }


}
