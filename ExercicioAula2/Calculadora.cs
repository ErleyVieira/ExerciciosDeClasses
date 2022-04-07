using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula2
{
    internal class Calculadora
    {
        public static double pi = 3.14;


        public static double Circuferencia(double r)
        {
            return 2.0 * pi * r;
            
        }
        public static double Volume(double r)
        {
            return 4.00 / 3.00 * pi * Math.Pow(r, 3);
        } 
    }
}
