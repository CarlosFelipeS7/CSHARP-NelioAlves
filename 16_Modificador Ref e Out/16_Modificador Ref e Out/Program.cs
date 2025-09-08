using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Modificador_Ref_e_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            Calculator.Triple(ref a);  //ref faz parametro x, referenciara A
            Console.WriteLine(a);

            int b = 50;
            int dobro;
            Calculator.Dobro(b, out dobro); //out faz um parametro seja referencia tbm, mas nao exige que a variavel original seja iniciada
            Console.WriteLine(dobro); 
        }
    }
}
