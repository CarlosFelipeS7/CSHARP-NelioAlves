using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Modificador_Ref_e_Out
{
    internal class Calculator
    {
        //statica pra ser chamada sem instancaiar objeto
        public static void Triple( ref int x) //parametro x, referenciara a variavel original
        {
            x = x * 3;
        }

        public static void Dobro(int origem, out int resultado)
        {
            resultado = origem * 2;
        }

    }
}
