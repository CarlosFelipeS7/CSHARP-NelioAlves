using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IComparable: interface generica do .NET
            //compara se objetos sao maiores ou menores que outro

            //posso comparar pessoa1 ={"idade = 30} e pessoa2 {idade=31}


            List<Produto> list = new List<Produto>();

            list.Add(new Produto(900, "TV"));
            list.Add(new Produto(1200, "Notebook"));
            list.Add(new Produto(450.00, "Tablet"));

            list.Sort();//sort so funciona se a lista implementa a interface IComparable

            foreach(Produto p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
