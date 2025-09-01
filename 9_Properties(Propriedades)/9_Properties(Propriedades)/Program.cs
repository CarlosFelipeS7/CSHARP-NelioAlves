using _9_Properties_Propriedades_;
using _9_Properties_Propriedades_;
using System;
using System.Globalization;
namespace _9_Properties_Propriedades_
{
    class Program
    {
 //Properties/Propriedades: sao definicoes de metodos encapsulados
 // com  sintaxe similar a de atributos e recursos de metodos


        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500, 10);

            //Nome é a unica variavel com um Set nas Properties, por isso é a unica que consigo modificar o valor, as demais so exibir
            p.Nome = "Celular";


            Console.WriteLine(p.Nome);

            Console.WriteLine(p.Quantidade);

            Console.WriteLine(p.Preco);

            



        }
    }
}