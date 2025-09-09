using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pega o horario atual do sistema
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            //escolhendo a data
            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);

            //escolhendo a data, e hora
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 30);
            Console.WriteLine(d3);

            //usando Parse
            DateTime d4 = DateTime.Parse("2004-08-24");
            Console.WriteLine(d4);

            //calcula atraves de ticks, um valor de nano segundos desde o dia 1
            Console.WriteLine(d1.Ticks);


        }
    }
}
