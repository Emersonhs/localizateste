using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Model
{
    public class ResultadoCalculo
    {
        public List<int> Divisores { get; set; }

       
        public List<int> Primos { get; set; }

        public ResultadoCalculo()
        {
            this.Divisores = new List<int>();
            this.Primos = new List<int>();
        }

    
    }
}
