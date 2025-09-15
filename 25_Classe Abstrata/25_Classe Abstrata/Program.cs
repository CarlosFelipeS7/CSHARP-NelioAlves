using _25_Classe_Abstrata.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Classe_Abstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //classe abstrata
            //nao podem ser instanciadas

            //mas posso criar uma lista do tipo
            List<Account> list = new List<Account>();

            //salvando tipos diferentes na mesma lista SuperClasse Generica
            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 800.00, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new SavingsAccount(1004, "Anna", 500.00, 500));

            double sum = 0;
            foreach(Account percorrer in list) //criei uma variavel percorrer do tipo Account, basicamente cada variavel account que tiver na lista (todos seja saving ou business)
            {
                sum += percorrer.Balance; //pegando total do saldo das contas
            }

            Console.WriteLine("Total balance: " + sum);


        }
    }
}
