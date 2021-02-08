using LocalizaTeste.Model;
using LocalizaTeste.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.web.Pages
{
    public class CalcularModel : PageModel
    {

        public Calcular calcular { get; set; }

        private readonly ILogger<ResultadoCalculo> _logger;
        [BindProperty]
        public ResultadoCalculo PageCalculo { get; set; }

        public CalcularModel()
        {
            PageCalculo = new ResultadoCalculo();
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            calcular = new Calcular();
            this.PageCalculo = calcular.TodosDivisores(this.PageCalculo.Numero);
           

            return Page();
        }

    }
}
