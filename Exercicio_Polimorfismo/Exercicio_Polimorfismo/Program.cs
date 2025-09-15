using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Polimorfismo.Entities;

namespace Exercicio_Polimorfismo
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();


            Console.WriteLine("Digite a quantidade de funcionarios: ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i =1; i<=qtd; i++)
            {
                Console.WriteLine($"Digite {i}° funcionario: ");
                Console.WriteLine($"Terceirizado? (s/n) ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Qtd Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
               
                if (ch == 's' || ch == 'S')
                {
                    Console.WriteLine("Despesa Adicionaç: ");
                    double despesaAdicional = double.Parse(Console.ReadLine());
                    funcionarios.Add(new Terceirizado (despesaAdicional, nome, horas, valorPorHora));
                }
                else
                {
                    funcionarios.Add(new Funcionario(nome, horas, valorPorHora));
                }
            }


            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Nome + " - $ " + funcionario.Pagamento().ToString("F2"));
            }



        }



    }
}
