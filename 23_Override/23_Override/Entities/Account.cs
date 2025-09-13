 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Override.Entities
{
    class Account
    {

        public int Number { get; set; } //numero da conta
        public string Holder { get; set; } //titular da conta
        public double Balance { get; set; } //saldo da conta

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;

        }

        //Metodo de Saque, que pode ser sobrescrito
        public virtual void Withdraw(double amount)//quantia //Metodo de Saque
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
