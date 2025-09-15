using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Classes_e_Metodos_Selados_sealed_.Entities
{
    class BusinessAccount : Account 
    {
        public double loanLimit { get; set; }


        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
    
            loanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
     
            if (amount <= loanLimit)
            {
                Balance += amount;
            }
        }

    }
}