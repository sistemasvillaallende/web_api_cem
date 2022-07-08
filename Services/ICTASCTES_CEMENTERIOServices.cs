using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api_Cem.Services
{
    public interface ICTASCTES_CEMENTERIOServices
    {
        public int insert(Entities.CTASCTES_CEMENTERIO obj);
        public void update(Entities.CTASCTES_CEMENTERIO obj);
        public void delete(Entities.CTASCTES_CEMENTERIO obj);
        public List<Entities.CTASCTES_CEMENTERIO> read();
        public List<Entities.CATE_DEUDA_CEMENTERIO> ListarCategorias();
        public Entities.CTASCTES_CEMENTERIO getByPk(int Tipo_transaccion, int Nro_transaccion, int Nro_pago_parcial);
        public List<Entities.CTASCTES_CEMENTERIO> List6arCtaCte(char Tipo, int Manzana, int Lote, int Parcela,
           int Nivel, int Tipo_consulta, int Categoria_desde, int Categoria_hasta);
    }
}
