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
    public class CementerioController : Controller
    {
        private ICementerioServices _icementerioService;
        public CementerioController(ICementerioServices cementerioServices)
        {
            _icementerioService = cementerioServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult insert(Entities.CEMENTERIO obj)
        {
            _icementerioService.insert(obj);
            var cementerio = _icementerioService.read();

            return Ok(cementerio);
        }
        [HttpPost]
        public IActionResult update(Entities.CEMENTERIO obj)
        {
            _icementerioService.update(obj);
            var cementerio = _icementerioService.read();

            return Ok(cementerio);
        }

        [HttpPost]
        public IActionResult delete(Entities.CEMENTERIO obj)
        {
            _icementerioService.delete(obj);
            var cementerio = _icementerioService.read();

            return Ok(cementerio);
        }
        [HttpGet]
        public IActionResult read()
        {
            var cementerio = _icementerioService.read();

            return Ok(cementerio);
        }
        [HttpGet]
        public IActionResult getByPk(char Tipo, int Manzana, int Lote, int Parcela, int Nivel)
        {
            var cementerio = _icementerioService.getByPk(Tipo, Manzana, Lote, Parcela, Nivel);

            return Ok(cementerio);
        }

    }
}