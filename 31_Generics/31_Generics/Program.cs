using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generics permitem que classes, interfaces e metodos 
            //possam ser parametrizados por tipo.

            PrintService printService = new PrintService();

            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.addValue(x);
            }
            printService.Print();
            Console.WriteLine("First: " + printService.First()); 

        }
    }
}
