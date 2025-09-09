using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matriz é bidmensional (linha e coluna), diferente do vetor

            //Criando matriz de 2 linhas e 3 colunas
            double[,] matrizCriada = new double[2, 3];

            Console.WriteLine(matrizCriada.Length); //qtd de elementos no total
            Console.WriteLine(matrizCriada.Rank); // qtd de linhas
            Console.WriteLine(matrizCriada.GetLength(0));//1 DIMENSAO = linhas
            Console.WriteLine(matrizCriada.GetLength(1));//2 DIMENSAO = colunas


        }
    }
}
