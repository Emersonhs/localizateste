using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaTeste.Model
{
    public class ResultadoCalculo
    {
        [Display(Name = "Numero")]
        public int Numero { get; set; }
        [Display(Name = "Todos os Divisores")]
        public string StrDivisores { get; set; }

        [Display(Name = "Numeros Primos")]
        public string StrPrimos { get; set; }

       
        public List<int> Divisores { get; set; }

       
        public List<int> Primos { get; set; }

        public ResultadoCalculo()
        {
            this.Divisores = new List<int>();
            this.Primos = new List<int>();
        }

        public void primosTostring()
        {
            if (this.Primos.Count > 0)
                foreach (var item in this.Primos)
                    this.StrPrimos = item + ", ";

        }
        public void DivisoresTostring()
        {
            if (this.Divisores.Count > 0)
                foreach (var item in this.Divisores)
                    this.StrDivisores = item + ", ";

        }
    }
}
