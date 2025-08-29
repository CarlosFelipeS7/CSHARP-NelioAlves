using _6_Sintaxe_Alternativa_Instanciar_Objetos;
using System;
using System.Globalization;
namespace _6_Sintaxe_Alternativa_Instanciar_Objetos
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            //Sintaxe alternativa pra instanciar valores sem construtor
            Produto p3 = new Produto() { 
                nome = "TV", 
                preco = 1000, 
                quantidade = 3 };

            Console.WriteLine(p3);
        }
    }
}