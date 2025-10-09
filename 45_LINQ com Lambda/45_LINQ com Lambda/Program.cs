using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _45_LINQ_com_Lambda.Entities;

namespace _45_LINQ_com_Lambda
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name="Tools", Tier=2};
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> listaProdutos = new List<Product>()
            {
                new Product(){Id = 1, Name = "Computer", Price = 1100, Category = c2},
                 new Product(){Id = 2, Name = "Hammer", Price = 50, Category = c1},
                  new Product(){Id = 3, Name = "Tv", Price = 800, Category = c2},
                 new Product(){Id = 4, Name = "MacBook", Price = 2300, Category = c2}

            };

            //LINQ
            var r1 = listaProdutos.Where(x => x.Category.Tier == 1 && x.Price>900);
           
            
            //Sintaxe de SQL no LINQ
            var r3 =
                from p in listaProdutos
                where p.Category.Tier == 1
                select p.Name;

           Print("Sintaxe Alternativa", r1);
            Print("Sintaxe Alternativa2",  r3);

            Print("TIER 1 AND PRICE > 900:", r1);

            var r2 = listaProdutos.Where(x=> x.Category.Name=="Tools").Select(x=> x.Name);
            Print("NAMES OF PRODUCT FROM TOOLS ", r2);

        }
    }
}
