using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Condicao_Ternaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());

            //Estrutura opcional ao if-else quando se deseja decidir um Valor com base em uma condicao

           var caroBarato = (preco > 10) ? "Caro" : "Barato";//se verdadeiro retorna "Caro" senao "Barato"

            Console.WriteLine(caroBarato);

        }
    }
}
