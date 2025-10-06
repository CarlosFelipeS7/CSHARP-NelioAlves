using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Delegates.Services
{
     class CalculateService
    {
        public static double Max(double x, double y) {
            return (x > y) ? x : y; //ternario: se x > y retorna x, senao y
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x) {
            return x * x;
        }


    }
}
