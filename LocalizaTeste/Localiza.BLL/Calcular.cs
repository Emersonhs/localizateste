
using Localiza.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.BLL
{
    public class Calcular
    {

        public ResultadoCalculo TodosDivisores(int num)
        {
            try
            {
                var resultado = new ResultadoCalculo();
                resultado = this.RetornaNumeroDivisores(num);
                return resultado;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ResultadoCalculo RetornaNumeroDivisores(int num)
        {
            try
            {
                var retorno = new ResultadoCalculo();
                int divisor = num;
                while (divisor != 0)
                {
                    if ((num % divisor) == 0)
                    {
                        retorno.Divisores.Add(divisor);
                        if (verificaPrimo(divisor))
                            retorno.Primos.Add(divisor);
                    }
                    divisor--;
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        private bool verificaPrimo(int num)
        {
            try
            {
                int count = 0;
                for (int i = num; i > 0; i--)
                {
                    if ((num % i) == 0)
                        count++;

                }
                if (count == 2 || num == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw;
            }

        }


    }
}
