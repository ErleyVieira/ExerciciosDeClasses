using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioListas
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
            
        public static void AumentarSalario(List<Employees> list)
        {
            Console.Write("Enter the employee id that will have salary increase : ");
            int id = int.Parse(Console.ReadLine());

            Employees emp = list.Find(x => x.Id == id);
            if (emp != null)
            {
                Console.Write("Enter the percentage:");
                double percentage = double.Parse(Console.ReadLine());
                emp.Salary *= 1 + (percentage * 0.01);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            
        }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + "Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
