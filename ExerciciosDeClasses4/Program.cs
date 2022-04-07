using System;

namespace ExerciciosDeClasses4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno();

            aluno1.Nome = "João";
            aluno1.Nota1 = 0;
            aluno1.Nota2 = 31.00;
            aluno1.Nota3 = 0;

            double resultado = aluno1.Media();

            Console.WriteLine("NOTA FINAL = " + resultado);
            Console.WriteLine(aluno1.Aprovacao());
            Console.WriteLine(aluno1.PontosFaltantes());
        }
    }
}
