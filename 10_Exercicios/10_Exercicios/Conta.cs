using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Exercicios
{
    class Conta
    {
        private int numero;
        private string nome;
        private double deposito;
        private double saque;

        public Conta(int numero, string nome, double deposito, double saque)
        {
            this.numero = numero;
            this.nome = nome;
            this.deposito = deposito;
            this.saque = saque;
            
        }


        public int getNumero()
        {
            return numero;
        }

        public int setNumero(int numero)
        {
            this.numero = numero;
            return numero;
        }

        public string getNome()
        {
            return nome;
        }

        public string setNome(string nome)
        {
            this.nome = nome;
            return nome;
        }

        public double getDeposito()
        {
            return deposito;
        }

        public double setDeposito(double deposito)
        {
            this.deposito = deposito;
            return deposito;
        }


        public double getSaque()
        {
            return saque;
        }

        public double setSaque(double saque)
        {
            this.saque = saque;
            return saque;
        }

    }
}
