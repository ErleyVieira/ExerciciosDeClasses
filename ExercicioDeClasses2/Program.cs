using ExercicioDeClasses2;
using System;
namespace ExerciciosDeClasses
{
    class program
    {
        static void Main(string[] args)
        {
            Funcionario anaMarques, carlosSilva;

            anaMarques = new Funcionario();
            carlosSilva = new Funcionario
            {
                salario = 6300.00,
                nome = "Carlos Silva"
            };
            anaMarques.salario = 6700.00;
            anaMarques.nome = "Ana Marques";


            Console.WriteLine("Dados do primeiro funcionário");
            Console.WriteLine("Nome: " + anaMarques.nome);
            Console.WriteLine("Salário: " + anaMarques.salario);
            Console.WriteLine("Dados do segundo funcionário");
            Console.WriteLine("Nome: " + carlosSilva.nome);
            Console.WriteLine("Salário: " + carlosSilva.salario);

            Console.WriteLine("Salário médio: " + (carlosSilva.salario + anaMarques.salario) / 2);
        }
    }
}


