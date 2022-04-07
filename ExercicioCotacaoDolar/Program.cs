using System;

namespace ExercicioCotacaoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valor = 200.00;
            double conversao = ConversorDeMoeda.Conversor(valor);
            Console.WriteLine(conversao.ToString("F2"));

        }
    }
}
