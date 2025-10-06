using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _39_Delegates.Services;

namespace _39_Delegates
{
    //Criando  Delegate
    delegate double BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            //Delegates: é uma referencia(com type safety) para metodos
            //Usos comuns: Comunicacao entre objetos de forma flexivel(callbacks/eventos)
            //Parametrizacao de operacoes por metodos


            double a = 10;
            double b = 12;

            //eu to fazendo a variavel op do tipo  Binary ser referencia ao metodo Sum
            BinaryNumericOperation op = CalculateService.Sum;

            //ai inves de fazer isso
            double result = CalculateService.Sum(a, b);
            
            //posso fazer isso
            double result2 = op(a, b);

            Console.WriteLine(result);

            Console.WriteLine(result2);
        }
    }
}
