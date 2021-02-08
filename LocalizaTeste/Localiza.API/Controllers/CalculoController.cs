
using Localiza.BLL;
using Localiza.Model;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.web.Controllers
{
    [ApiController]
    [Route("api/calculos")]
    public class CalculoController : Controller
    {
        [HttpGet]
        [Route("todosdivisores")]
        public ResultadoCalculo Index(int numero)
        {
            Calcular calc = new Calcular();
            var result = calc.TodosDivisores(numero);
            return result;
        }
    }
}
