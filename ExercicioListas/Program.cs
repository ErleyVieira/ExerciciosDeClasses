using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many employees will be registered?");
            int number = int.Parse(Console.ReadLine());
            List<Employees> list = new ();
            for ( int i = 1; i <= number; i++)
            {
                
                Console.WriteLine("Emplyoee #"+i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }

            Employees.AumentarSalario(list);

            foreach (Employees obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        
    }
}
