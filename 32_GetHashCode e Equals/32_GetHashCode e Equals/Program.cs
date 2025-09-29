using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _32_GetHashCode_e_Equals.Entities;

namespace _32_GetHashCode_e_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pelo que entendi o hashcode é uma busca mais generica, porem mais rapida
            //O equals é mais lenta, porem 100%

            //Analogia: objeto:livro, o hashcode seria localizar as pratileiras rapido
            //o equals seria ver o nome do livro e autor

            //Entao utiliza os 2

            //Equals:  retorna se os valores dos objetos sao iguais
            string a = "Maria";
            string b = "Alex";
            Console.WriteLine(a.Equals(b)); //false
            string e = "Lucas";
            string f = "Lucas";
            Console.WriteLine(e.Equals(f)); //retorna true, pois os objetos tem o mesmo valor, mesmo sendo difrentes

            //GetHashCode: retorna um codigo a partir das infos do objeto
            string c = "Pedro";
            string d = "Pedro";
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());


            Client cliente1 = new Client { Email = "maria@gmail.com", Name = "Maria" };
           Client cliente2 = new Client { Name = "Alex", Email = "alex@gmail.com"};

            Console.WriteLine(cliente1.Equals(cliente2));
            Console.WriteLine(cliente1.GetHashCode());
            Console.WriteLine(cliente2.GetHashCode());
            


        }
    }
}
