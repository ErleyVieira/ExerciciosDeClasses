using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProposstosContaBancaria
{
    internal class ContaBancaria
    {
        public string Nome { get; set; }
        public double NumeroConta { get; private set; }
        public double SaldoConta { get; private set; }

        
        public void AbrirConta()
        {
            Console.Write("Entre com o número da conta: ");
            NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial ? [S/N]");
            string deposito = Console.ReadLine().ToUpper();
            if (deposito == "S")
            {
                Console.Write("Entre com o valor inicial: ");
                double saldodaconta = double.Parse(Console.ReadLine());
                SaldoConta = saldodaconta;
            }
            else
            {
                SaldoConta = 0;
            }
        }
        public double Depositar()
        {
            Console.WriteLine("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            return SaldoConta += valor;
        }
        public double Sacar()
        {
            Console.WriteLine("Entre um valor para saque: ");
            double valor = double.Parse(Console.ReadLine());
            valor += 5;
            return SaldoConta -= valor;
        }
        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + Nome + ", Saldo da conta: $" + SaldoConta; 
        }
    }
    
    
}
