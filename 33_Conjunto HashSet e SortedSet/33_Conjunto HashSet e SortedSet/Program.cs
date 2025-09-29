using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Conjunto_HashSet_e_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet<T> e SortedSet<T>: representam um conjunto de elementos
            //(nao tem repeticoes, nao tem ordem usado no lugar do List<>)

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach(string i in set)
            {
                Console.WriteLine(i);
            }



        }
    }
}
