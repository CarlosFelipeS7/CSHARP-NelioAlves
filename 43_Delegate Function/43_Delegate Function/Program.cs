using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Delegate_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900));
            list.Add(new Product("Mouse", 50));
            list.Add(new Product("Tablet", 200));
            list.Add(new Product("HD", 90));

            //faznedo um delegate que recebe um objeto product e retorna uma string
            Func<Product, string> func = NameUpper;

            //funcao select, pega uma colecao e transforma em outra
            List<string> result = list.Select(func).ToList();
            //cada elemento da lista original, sera aplicado a funcao nameUpper e sera salvo a uma nova colecao
        }   

        static string NameUpper(Product p)
        {
            return p.name.ToUpper();
        }
    }
}
