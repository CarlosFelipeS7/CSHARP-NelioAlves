using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vantagem de usar Vetor: Acesso imediato pela posicao

            //Desvantagem: Tamanho Fixo, Dificuldade de Inserir/Deletar
            Console.WriteLine("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            double[] vetorCriado = new double[n]; //qtd de elementos 

            for (int i = 0; i < n; i++) {
                //Adicionando elementos no vetor
                Console.WriteLine("Digite um valor para adicionar ao vetor: ");
                
                vetorCriado[i] = double.Parse(Console.ReadLine());
            }


            double sum = 0.0;

            for(int i = 0; i< n; i++)
            {
                sum += vetorCriado[i];
            }

            double media = sum / n;

            Console.WriteLine("Media dos elementos do vetor: " + media);
    



        }
    }
}
