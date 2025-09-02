using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Tipos_Referencia_e_Valor
{
    //criando struct
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }

    }
}
