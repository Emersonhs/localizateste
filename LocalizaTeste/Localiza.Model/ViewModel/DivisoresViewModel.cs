using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Model.ViewModel
{
    public class DivisoresViewModel
    {

        [Display(Name = "Numero")]
        public int Numero { get; set; }
        [Display(Name = "Todos os Divisores")]
        public string StrDivisores { get; set; }

        [Display(Name = "Numeros Primos")]
        public string StrPrimos { get; set; }

        public ResultadoCalculo resultadoCalculo{ get; set; }
        public void primosTostring()
        {
            string novaPrimos = "";
            if (this.resultadoCalculo.Primos.Count > 0)
                foreach (var item in this.resultadoCalculo.Primos)
                    novaPrimos += item + ", ";
            this.StrPrimos = novaPrimos.Remove(novaPrimos.Length - 2);


        }
        public void DivisoresTostring()
        {
            string novaDivisores ="";
            if (this.resultadoCalculo.Divisores.Count > 0)
                foreach (var item in this.resultadoCalculo.Divisores)
                    novaDivisores += item + ", ";
            this.StrDivisores = novaDivisores.Remove(novaDivisores.Length - 2);
        }
    }
}
