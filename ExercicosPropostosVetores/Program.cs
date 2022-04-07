using System;

namespace ExercicosPropostosVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many rooms will be rented ?");
            int n = int.Parse(Console.ReadLine());

            Rooms[] vect = new Rooms[10];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #" + i);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Rooms { Name = name, Email = email};
                
            }
            Console.WriteLine("Busy Rooms:");
            
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }            
        }
    }
}
