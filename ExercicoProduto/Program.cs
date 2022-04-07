using System;

namespace ExercicoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new("tv", 900.00, 0);

            p.Nome = "T";

           Console.WriteLine(p.Preco);
            Console.WriteLine(p.Nome);
        }
    }
}
