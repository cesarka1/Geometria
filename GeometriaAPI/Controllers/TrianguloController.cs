using Microsoft.AspNetCore.Mvc;
using GeometriaAPI.Models;
using System;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrianguloController
    {
        [HttpGet]
        [Route("GetArea")]
        public ActionResult<string> GetArea(double basev, double alturav)
        {
            Triangulo triangulo = new Triangulo();
            string[] medidas = {basev.ToString(), alturav.ToString()};
            return triangulo.CalcularArea(medidas).ToString();
        }
    }
}