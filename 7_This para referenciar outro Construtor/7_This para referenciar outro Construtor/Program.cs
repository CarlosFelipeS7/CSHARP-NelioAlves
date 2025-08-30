using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_This_para_referenciar_outro_Construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Notebook", 2500.0, 5);
            Console.WriteLine("\nObjeto final:");
            Console.WriteLine(p);


        }
    }
}
