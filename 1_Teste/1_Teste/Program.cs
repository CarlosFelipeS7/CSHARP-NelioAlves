using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Console.WriteLine("Digite o nome da 1 pessoa: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da 1 pessoa");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da 2 pessoa: ");
            string nome2 = Console.ReadLine();

            Console.WriteLine("Digite a idade da 2 pessoa");
            int idade2 = int.Parse(Console.ReadLine());

          class1.maior(nome, nome2, idade, idade2);
        

        }
    }
}
