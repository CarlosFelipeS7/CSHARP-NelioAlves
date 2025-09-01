using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(0000, "luiz", 0000, 000);
            Console.WriteLine("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            conta.setNumero(numero);

            Console.WriteLine("Titular da conta: ");
            string nome = Console.ReadLine();
            conta.setNome(nome);

            Console.WriteLine("Havera deposito (s/n) ?");
            string resposta = (Console.ReadLine());
            if(resposta == "s" || resposta == "S")
            {
                Console.WriteLine("Entre com o valor do deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                conta.setDeposito(deposito);

                Console.WriteLine("Dados da Conta: ");
                Console.WriteLine( "Conta: " + conta.getNumero()
                    + ", Titular: " + conta.getNome() 
                    + ", Deposito: " + conta.getDeposito());

            }
            else
            {
                Console.WriteLine("Entre com o valor do saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.setSaque(saque);

                Console.WriteLine("Dados da Conta: ");
                Console.WriteLine("Conta: " + conta.getNumero()
                    + ", Titular: " + conta.getNome()
                    + ", Saque: " + conta.getSaque());
            }
        }
    }
}
