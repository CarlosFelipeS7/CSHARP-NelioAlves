using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Comparison_T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            List<Produto> list = new List<Produto>();

            list.Add(new Produto(900, "TV"));
            list.Add(new Produto(1200, "Notebook"));
            list.Add(new Produto(450.00, "Tablet"));

            //o sort compara elementos de uma lista e ordena se a interface IComparable tiver implementada 

            //mas como nao esta, podemos fazer um delegate, adaptar outra funcao para o sort usar na lista para comparar os elementos
            list.Sort(CompararProdutos);//delegate, fazer referencia a outra funcao, entao de 2 em 2 ele ordena a lista toda

            foreach (Produto p in list)
            {
                Console.WriteLine(p);
            }
        }

            static int CompararProdutos(Produto p1, Produto p2) //essa funcao base so compara 2 elementos
        {
            return p1.nome.ToUpper().CompareTo(p2.nome.ToUpper());
        }
    }
}
