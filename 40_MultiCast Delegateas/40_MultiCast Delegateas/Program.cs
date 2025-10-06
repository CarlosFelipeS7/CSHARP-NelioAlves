using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _40_MultiCast_Delegateas.Services;

namespace _40_MultiCast_Delegateas
{
    delegate void BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            //MultiCast Delegates: delegates que guardam referencia de mais de um metodo

            double a = 10;
            double b =12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax; //atribuindo segunda funcao ao op

            op.Invoke(a, b);//invoke, mostrando as funcoes referenciadas no op

        }
    }
}
