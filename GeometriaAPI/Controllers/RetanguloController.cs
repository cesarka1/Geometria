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
         public ActionResult<string> GetArea(double basev, double alturav){
            Retangulo retangulo = new Retangulo();
            string[] medidas = {basev.ToString(), alturav.ToString()};
            return Convert.ToString(retangulo.CalcularArea(medidas));
         }
    }
}