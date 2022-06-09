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
         public ActionResult<string> GetArea(){
            Retangulo retangulo = new Retangulo();
            string[] medidas = {"5", "5"};
            return Convert.ToString(retangulo.CalcularArea(medidas));
         }
    }
}