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
        public List<int> Divisores { get; set; }

        [Display(Name = "Numeros Primos")]
        public List<int> Primos { get; set; }

        public ResultadoCalculo()
        {
            this.Divisores = new List<int>();
            this.Primos = new List<int>();
        }
    }
}
