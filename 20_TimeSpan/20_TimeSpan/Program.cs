using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan representa um intervalo entre 2 instantes
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks); //100 nanosegundos equivalente a 1:30min


        }
    }
}
