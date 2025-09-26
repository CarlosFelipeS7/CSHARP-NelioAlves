using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_GetHashCode_e_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ambas sao operacoes da classe Object
            //Para comparar se um objeto é igual a outro

            //Equals: lento, resposta 100%, retorna true ou false
            string a = "Maria";
            string b = "Alex";
            Console.WriteLine(a.Equals(b));

            //GetHashCode: rapido, porem nao é 100%, retorna um codigo a partir das infos do objeto
            string c = "Pedro";
            string d = "Pedro";
            Console.WriteLine(c.GetHashCode());  
            Console.WriteLine(d.GetHashCode());

            
            


        }
    }
}
