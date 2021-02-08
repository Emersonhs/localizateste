using Localiza.BLL;
using Localiza.Model;
using Localiza.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Localiza.web.Pages
{
    [ActivatorUtilitiesConstructor]
    public class CalcularModel : PageModel
    {

        public Calcular calcular { get; set; }

        [BindProperty]
        public DivisoresViewModel VmDivisores { get; set; }

        public CalcularModel()
        {
            VmDivisores = new  DivisoresViewModel();
           
        }
       
        public void OnGet()
        {

        }
        [HttpPost]
        public IActionResult OnPost()
        {
            try
            {
                calcular = new Calcular();
                this.VmDivisores.resultadoCalculo = calcular.TodosDivisores(this.VmDivisores.Numero);
                this.VmDivisores.DivisoresTostring();
                this.VmDivisores.primosTostring();
            }
            catch (Exception ex)
            {

                RedirectToAction("Error");
            }
            return Page();
        }

    }
}
