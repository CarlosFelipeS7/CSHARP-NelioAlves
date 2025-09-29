using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Mais_HashSet_e_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int>a = new SortedSet<int>() { 1, 3, 5, 7, 5, 9, 11 };
            SortedSet<int> b = new SortedSet<int>() { 2, 4, 6, 8, 10 };

            PrintarColeção(a);

            //Uniao de Conjuntos
            SortedSet<int> c = new SortedSet<int>(a); //Instanciando um novo conjunto c com todos elementos do conjunto a
            c.UnionWith(b);//fazendo a uniao de c com b, inserir em c todos elementos de b que nao estejam em c
            PrintarColeção(c);

            //Interseccao
            SortedSet<int> d = new SortedSet<int>(a);
            Console.WriteLine("InterSeccao");
            d.Intersect(c);
            PrintarColeção(d);
        }  

        //Percorrer a colecao com a interface IEnumerable
        static void PrintarColeção <T>(IEnumerable<T> collection) //Interface implementada por todas colecoes basicas
        {
            foreach (T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }
        } 

    }
}
