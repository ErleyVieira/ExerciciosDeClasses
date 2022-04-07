using System;

namespace ExerciciosProposstosContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ContaBancaria conta1 = new();
            ContaBancaria conta2 = new();
            conta1.AbrirConta();

            Console.WriteLine(conta1);
            conta1.Depositar();
            Console.WriteLine(conta1);
            conta1.Sacar();
            Console.WriteLine(conta1);

            conta2.AbrirConta();
            Console.WriteLine(conta2);
            conta2.Depositar();
            Console.WriteLine(conta2);
            conta2.Sacar();
            Console.WriteLine(conta2);





            



        }
    }
}
