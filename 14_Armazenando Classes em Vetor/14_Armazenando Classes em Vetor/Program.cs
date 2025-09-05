using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Armazenando_Classes_em_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int quantidade = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[quantidade]; //vetor criado do tipo Classe

            for (int i = 0; i < quantidade; i++) //baseado na quantidade repete o cdodigo
            {
                //Leitura dos dados
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                //Instanciando vetor (sem construtor)
                vetor[quantidade] = new Produto { Nome = nome, Preco = preco };
            }



        }
    }
}
