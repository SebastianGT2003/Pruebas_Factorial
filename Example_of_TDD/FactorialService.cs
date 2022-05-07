using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_TDD
{
    public class FactorialService
    {
        public FactorialService()
        {

        }
        //Minimo codigo ppara que las pruebas pasen

        //public int Calculate(int number)
        //{
        //    if (number == 0)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return number* Calculate(number-1);
        //    }
        //}

        // Codigo Refactorizado


        public int Calculate(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                int resultado=1;
                for (int i=1; i<=number; i++)
                {
                    resultado*=i;

                }
                return resultado;
            }
        }
    }
}
