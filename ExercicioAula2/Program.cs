using System;

namespace ExercicioAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double raio = 3.00;

            double circ = Calculadora.Circuferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circuferência:" + circ.ToString("F2"));
            Console.WriteLine("Volume " + vol.ToString("F2"));
            Console.WriteLine("Valor de pi: " + Calculadora.pi.ToString("F2"));

        }
    }
}
