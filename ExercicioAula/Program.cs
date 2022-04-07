using System;

namespace ExercicioAula
{
    internal class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);


            double circ = Circuferencia(raio);
            double vol = Volume(raio);
            Console.WriteLine("Circuferência: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + vol.ToString("F2"));
            Console.WriteLine("Valor de pi: " + pi);
        }
        
        static double Circuferencia(double r)
        {
            return 2 * pi * r; 
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3);
        }
    
    }   
}
