using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCotacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static double CotacaoDolar = 3.1;

        public static double Conversor(double v)
        {
            double resultado = v * CotacaoDolar;
            return resultado + (resultado * 0.06); 
            
        }
    }
}
