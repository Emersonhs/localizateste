using LocalizaTeste.Model;
using LocalizaTeste.Negocio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaTeste.Controllers
{
    [ApiController]
    [Route("calcular")]
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
