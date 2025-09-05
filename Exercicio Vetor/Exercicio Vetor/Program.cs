using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Quantos quartos vao ser alugados? ");
            int alugado = int.Parse(Console.ReadLine());


            Estudante[] vetor = new Estudante[alugado];


            for (int i = 0; i<alugado; i++)
            {
                Console.WriteLine($"Digite o {i} quarto a ser alugado");
                int hospedado = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do aluno que alugou: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o email de quem alugou: ");
                string email = Console.ReadLine();

                vetor[i] = new Estudante { Nome = nome, Email = email, Hospedado = hospedado };

            }

            for (int i = 0; i < alugado; i++)
            {
                Console.WriteLine($"Quarto: {vetor[i].Hospedado}, Nome: {vetor[i].Nome}, Email: {vetor[i].Email}");
            }

       

        }
    }
}
