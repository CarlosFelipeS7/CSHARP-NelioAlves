using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_LocadoraVeiculos_Sem_Interface.Services
{
     class BrazilTaxService: ITaxService //definindo braziltaxservice como subtipo da interface
    { //se o braziltaxservice faz parte da itaxservice, deve implementar o metodo tax
        public double Tax(double amount)
        {
            if(amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
                
        }
    }
}
