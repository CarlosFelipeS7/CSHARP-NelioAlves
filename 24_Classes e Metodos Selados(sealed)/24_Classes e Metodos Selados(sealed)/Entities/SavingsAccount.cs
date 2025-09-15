using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Classes_e_Metodos_Selados_sealed_.Entities
{
    sealed class SavingsAccount : Account //classe selada
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


        //Metodo selado, evitar que um metodo sobreposto possa ser sobreposto novamente
        //so pode ser aplicado em metodos sobrepostos
        
        //ou seja, essa operacao nao pode ser sobreescrita novamente em outra subclasse
        public sealed override void Withdraw(double amount)
        {
         

            Balance -= amount;
        }


    }
}
