using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_Api_Cem.Entities;
using Web_Api_Cem.Services;

namespace Web_Api_Cem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CtasCtes_CementerioController : Controller
    {
        private ICTASCTES_CEMENTERIOServices _ictasctes_cementerioService;
        public CtasCtes_CementerioController(ICTASCTES_CEMENTERIOServices CTASCTES_CEMENTERIOServices)
        {
            _ictasctes_cementerioService = CTASCTES_CEMENTERIOServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult insert(Entities.CTASCTES_CEMENTERIO obj)
        {
            _ictasctes_cementerioService.insert(obj);
            var ctasctes_cementerio = _ictasctes_cementerioService.read();

            return Ok(ctasctes_cementerio);
        }
        [HttpPost]
        public IActionResult update(Entities.CTASCTES_CEMENTERIO obj)
        {
            _ictasctes_cementerioService.update(obj);
            var ctasctes_cementerio = _ictasctes_cementerioService.read();

            return Ok(ctasctes_cementerio);
        }

        [HttpPost]
        public IActionResult delete(Entities.CTASCTES_CEMENTERIO obj)
        {
            _ictasctes_cementerioService.delete(obj);
            var ctasctes_cementerio = _ictasctes_cementerioService.read();

            return Ok(ctasctes_cementerio);
        }
        [HttpGet]
        public IActionResult read()
        {
            var ctasctes_cementerio = _ictasctes_cementerioService.read();

            return Ok(ctasctes_cementerio);
        }
        [HttpGet]
        public IActionResult ListarCategorias()
        {
            var ctasctes_cementerio = _ictasctes_cementerioService.ListarCategorias();

            return Ok(ctasctes_cementerio);
        }
        [HttpGet]
        public IActionResult getByPk(int Tipo_transaccion, int Nro_transaccion, int Nro_pago_parcial)
        {
            var ctasctes_cementerio = _ictasctes_cementerioService.getByPk(Tipo_transaccion, Nro_transaccion, Nro_pago_parcial);

            return Ok(ctasctes_cementerio);
        }
        [HttpGet]
        public IActionResult List6arCtaCte(char Tipo, int Manzana, int Lote, int Parcela,
           int Nivel, int Tipo_consulta, int Categoria_desde, int Categoria_hasta)
        {
            var ctasctes_cementerio = _ictasctes_cementerioService.List6arCtaCte(Tipo,Manzana,Lote,Parcela,Nivel,Tipo_consulta,Categoria_desde,Categoria_hasta);

            return Ok(ctasctes_cementerio);
        }

    }
}
