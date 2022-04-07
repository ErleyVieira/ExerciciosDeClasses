using System;
using System.Collections.Generic;

namespace ProblemaExemplo2Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

           List<string> list = new ();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
