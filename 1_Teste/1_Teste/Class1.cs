using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Teste
{
    internal class Class1
    {
        private string nome, nome2;
        private int idade, idade2;

        public void maior(string nome, string nome2, int idade, int idade2)
        {
            this.nome = nome;
            this.nome2 = nome2;
            this.idade = idade;

            if (idade > idade2)
            { 
               Console.WriteLine("A pessoa mais velha " + nome + " tem de idade: " + idade);
            }

            else if (idade < idade2)
            {
                Console.WriteLine("A pessoa mais velha " + nome2 + " tem de idade: " + idade2);
            }

            else if(idade == idade2)
            {
                Console.WriteLine("As idades sao iguais");
            }



        }
        


    }
}
