using Microsoft.AspNetCore.Mvc;
using GeometriaAPI.Models;
using System;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetanguloController : ControllerBase
    {
        [HttpGet]
        [Route("GetArea")]
         public ActionResult<string> GetArea(double basev, double alturav){
            Retangulo retangulo = new Retangulo();
            string[] medidas = {basev.ToString(), alturav.ToString()};
            return Convert.ToString(retangulo.CalcularArea(medidas));
        }
        [HttpGet]
        [Route("GetPerimetro")]
        public ActionResult<string> GetPerimetro(double basev, double alturav)
        {
            Retangulo retangulo = new Retangulo();
            string[] medidas = {basev.ToString(), alturav.ToString()};
            return retangulo.CalcularPerimetro(medidas).ToString();
        }
    }
}