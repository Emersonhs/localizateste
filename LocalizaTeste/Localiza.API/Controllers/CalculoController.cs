
using Localiza.BLL;
using Localiza.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
            try
            {
                Calcular calc = new Calcular();
                var result = calc.TodosDivisores(numero);
                result.statusCode = HttpStatusCode.OK;
                return result;
            }
            catch (System.Exception ex)
            {
                return new ResultadoCalculo() { statusCode = HttpStatusCode.BadRequest, mensagem = ex.Message };
            }
        }
    }
}
