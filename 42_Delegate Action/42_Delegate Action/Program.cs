using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Delegate_Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Delegate Action
            //generico do .NET usado para armazenar metodos voids

            List<Product> list = new List<Product>();

            list.Add(new Product("tv", 500));
            list.Add(new Product("mouse", 800));
            list.Add(new Product("tv", 900));

            Action<Product> act = p => { p.Price += p.Price * 0.1};

            list.ForEach(act);
            

           
        }
    }
}
