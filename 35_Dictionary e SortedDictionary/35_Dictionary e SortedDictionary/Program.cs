using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Dictionary_e_SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary é uma colecao de pares chave,valor
            //armazenamento em tabela hash

            Dictionary<string, string> crieiCookies = new Dictionary<string, string>();
            //armazenando valores no dicionario
            crieiCookies["usuario"]= "joao";
            crieiCookies["email"] = "joaozinho@gmail.com";
            Console.WriteLine(crieiCookies["usuario"]);

            //SortedDictionary
                //armazenamento em arvore



        }
    }
}
