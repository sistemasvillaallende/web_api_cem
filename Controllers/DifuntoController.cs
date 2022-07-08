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
    public class DifuntoController : Controller
    {
        private IDifuntosServices _difuntoService;
        public DifuntoController(IDifuntosServices difuntosServices)
        {
            _difuntoService = difuntosServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult insert(Entities.DIFUNTOS obj)
        {
            _difuntoService.insert(obj);
            var difunto = _difuntoService.read();

            return Ok(difunto);
        }
        [HttpPost]
        public IActionResult update(Entities.DIFUNTOS obj)
        {
            _difuntoService.update(obj);
            var difunto = _difuntoService.read();

            return Ok(difunto);
        }
       
        [HttpPost]
        public IActionResult delete(Entities.DIFUNTOS obj)
        {
            _difuntoService.delete(obj);
            var difunto = _difuntoService.read();

            return Ok(difunto);
        }
        [HttpGet]
        public IActionResult read()
        {
            var difunto = _difuntoService.read();

            return Ok(difunto);
        }
        [HttpGet]
        public IActionResult BuscarDifuntos(char Tipo, int Manzana, int Lote, int Parcela, int Nivel)
        {
            var difunto = _difuntoService.BuscarDifuntos(Tipo,Manzana,Lote, Parcela, Nivel);

            return Ok(difunto);
        }
        [HttpGet]
        public IActionResult getByPk(char Tipo, int Manzana, int Lote, int Parcela, int Nivel)
        {
            var difunto = _difuntoService.getByPk(Tipo, Manzana, Lote, Parcela, Nivel);

            return Ok(difunto);
        }

    }
}
