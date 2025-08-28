using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membros_Estaticos
{
    internal class Program
    {
        //Static siginifica que pertence a classe e nao a um objeto

        //variavel estatica pois vai ser usada em funcoes staticas
        static double Pi = 3.14;

        static void Main(string[] args)   //so consigo chamar funcoes estaticas dentro dessa 
        {

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circuferencia(raio);

            Console.WriteLine("Circuferencia: " + circ);
        }

        //funcao statica pois vai ser chamada dentro da funcao main (tambem é estatica)
        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;

        }


    }
}
