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
    public class Titulares_x_CementerioController : Controller
    {
        private ITitulares_x_CementerioServices _titulares_x_CementerioService;
        public Titulares_x_CementerioController(ITitulares_x_CementerioServices titulares_x_CementerioServices)
        {
            _titulares_x_CementerioService = titulares_x_CementerioServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult insert(Entities.TITULARES_X_CEMENTERIO obj)
        {
            _titulares_x_CementerioService.insert(obj);
            var titulares = _titulares_x_CementerioService.read();

            return Ok(titulares);
        }
        [HttpPost]
        public IActionResult update(Entities.TITULARES_X_CEMENTERIO obj)
        {
            _titulares_x_CementerioService.update(obj);
            var titulares = _titulares_x_CementerioService.read();

            return Ok(titulares);
        }

        [HttpPost]
        public IActionResult delete(Entities.TITULARES_X_CEMENTERIO obj)
        {
            _titulares_x_CementerioService.delete(obj);
            var titulares = _titulares_x_CementerioService.read();

            return Ok(titulares);
        }
        [HttpGet]
        public IActionResult read()
        {
            var titulares = _titulares_x_CementerioService.read();

            return Ok(titulares);
        }
        [HttpGet]
        public IActionResult listarTitulares(char Tipo, int Manzana, int Lote, int Parcela,int Nivel)
        {
            var titulares = _titulares_x_CementerioService.listarTitulares(Tipo, Manzana, Lote, Parcela, Nivel);

            return Ok(titulares);
        }

        [HttpGet]
        public IActionResult getByPk(char Tipo, int Manzana, int Lote, int Parcela, int Nivel, int Nro_titular)
        {
            var titulares = _titulares_x_CementerioService.getByPk(Tipo, Manzana, Lote, Parcela, Nivel,Nro_titular);

            return Ok(titulares);
        }
    }
}
