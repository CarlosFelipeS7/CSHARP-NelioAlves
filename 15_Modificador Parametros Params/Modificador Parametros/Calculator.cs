using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificador_Parametros
{
     class Calculator
    {


        //Solucao com vetor
        public static int Soma(params int[] numbers) //params: diz pro copilador que a solucao pode receber uma quantia variavel de valores
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }







        //3 sobrecargas (errado)
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }




    }
}
