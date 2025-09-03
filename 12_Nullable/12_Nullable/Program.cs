using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Nullable 
//Recurso de C# para que dados do tipo valor(structs) possam receber o valor null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double? x = null; //variavel nullable pode ser declara com Nullable<double> x = null;
           
            //double? a =  x ?? 5.5; com esse operador, se x estiver nulo, a recebe o valor que eu passar apos ??, senao recebe o valor de x

            double? y = 10.0;

            //pega o valor do x, caso seja nulo, valor padrao da variavel x (double = 0)
            Console.WriteLine(x.GetValueOrDefault());

            //mesma coisa que acima
            Console.WriteLine(y.GetValueOrDefault());

            //Verificando se existe valor na variavel x, false
            Console.WriteLine(x.HasValue);

            //Verificando se existe valor na variavel y, true
            Console.WriteLine(y.HasValue);


            if (x.HasValue)
            {

                //Pegando somente o valor do x  
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
                
            //Pegando somente o valor do y
                Console.WriteLine(y.Value);

        }
    }
}
