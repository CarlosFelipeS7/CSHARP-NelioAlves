using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _25_Classe_Abstrata.Entities
{
    class BusinessAccount : Account //Herança
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