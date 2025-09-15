using _24_Classes_e_Metodos_Selados_sealed_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Classes_e_Metodos_Selados_sealed_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classe selada(sealed): evita que a classe seja herdada, serve como seguranca(ainda é possivel estender uma funcionalidade usando extends)
            Account acc1 = new Account(1001, "Alex", 500.0);

           

            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

       
            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
