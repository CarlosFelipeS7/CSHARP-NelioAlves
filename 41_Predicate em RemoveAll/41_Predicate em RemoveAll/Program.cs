using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Predicate_em_RemoveAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imaginando que tenho uma classe Produto com nome, e preço 
            //e 3 objetos instanciados

            list.Add(new Product("TV" 900));

            list.Add(new Product("TV" 500));

            list.Add(new Product("TV" 400));

            //Predicate com LAMBDA
            //Removendo tudo que é de 500 pra baixo
            list.RemoveAll(p => p.Preço <= 500);  
        }
    }
}
