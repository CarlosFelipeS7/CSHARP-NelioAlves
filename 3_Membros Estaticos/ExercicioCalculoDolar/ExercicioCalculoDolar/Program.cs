using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculoDolar
{
    internal class Program
    {
        static double iof = 0.06;

        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade a ser comprada de dolares? ");
            double quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago ");

            double total = Total(cotacao, quantidade);

            Console.WriteLine(total);
        }

        static double Total(double cotacao, double quantidade)
        {

           double taxa = cotacao * quantidade;

            double desconto = taxa * iof;

            return desconto + taxa;

      }

    }
}
