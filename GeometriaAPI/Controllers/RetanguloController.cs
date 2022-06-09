using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetanguloController : ControllerBase
    {
        [HttpGet]
         public ActionResult<string> GetArea(){
            return "10";
         }
    }
}