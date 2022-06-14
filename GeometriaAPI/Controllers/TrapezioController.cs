using Microsoft.AspNetCore.Mvc;
using GeometriaAPI.Models;
using System;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrapezioController : ControllerBase
    {
        [HttpGet]
        [Route("GetArea")]
         public ActionResult<string> GetArea(double basemaior, double basemenor, double altura){
            Trapezio trapezio = new Trapezio();
            string[] medidas = {basemaior.ToString(), basemenor.ToString(), altura.ToString()};
            return Convert.ToString(trapezio.CalcularArea(medidas));
        }
        [HttpGet]
        [Route("GetPerimetro")]
        public ActionResult<string> GetPerimetro(double lado1, double lado2, double basemenor, double basemaior)
        {
            Trapezio trapezio = new Trapezio();
            string[] medidas = {lado1.ToString(), lado2.ToString(), basemaior.ToString(), basemenor.ToString()};
            return trapezio.CalcularPerimetro(medidas).ToString();
        }
    }
}