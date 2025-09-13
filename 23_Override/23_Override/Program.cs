using _23_Override.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _23_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Override/Sobreposicao/SobreEscrita

            // eu tenho um metodo de sacar na classe generica Conta,
            // que ao realizar saque cobra 5 de taxa,
            // e na subclasse ContaVip nao tem taxa de saque,
            // entao eu colocaria virtual no metodo da superclasse,
            // e override no da conta vip

            Account acc1 = new Account(1001, "Alex", 500.0);
           
            //Upcasting, criando uma variavel account e instanciando um objeto savingsaccount
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            //saque diferente pois fiz sobreposicao/sobreescrita/override
            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);//consultando saldo apos o saque
            Console.WriteLine(acc2.Balance);
        }
    }
}
