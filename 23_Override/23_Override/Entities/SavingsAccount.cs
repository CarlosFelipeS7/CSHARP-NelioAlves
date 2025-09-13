using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Override.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //essa classe herda o saque comum com taxa da conta account
        //para isso irei sobreescrever pro saque funcionar diferente

        public override void Withdraw(double amount)
        {
            //Com a base eu poderia implementar o saque padrao com desconto de 5
            //e ainda implementar mais 2 de taxa
            //ou seja base permite reutilizar a funcao e implementar mais coisas

            //base.Withdraw(amount); 
            //Balance -= 2.0;

            Balance -= amount;
        }

       
    }
}
