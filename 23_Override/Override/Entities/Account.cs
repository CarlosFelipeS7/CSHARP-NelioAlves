using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
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

        //Metodo de Saque
        public void Withdraw(double amount)//quantia //Metodo de Saque
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
