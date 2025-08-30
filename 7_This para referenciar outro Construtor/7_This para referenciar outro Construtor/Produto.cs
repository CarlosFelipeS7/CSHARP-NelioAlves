using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_This_para_referenciar_outro_Construtor
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        //Pelo que entendi, baseado na assinatura é chamado um construtor
        //O objeto com nome, preco e quantidade: inicia o construtor 3, que vai pro 2, e vai pro 1 definir, depois que os valores foram definidos, desce do 1,2 e termina no de assinatura igual (3)


        // Construtor 1: sem parâmetros
        public Produto()
        {
            quantidade = 10;
            Console.WriteLine("Construtor Produto() chamado: quantidade = 10");
        }

        // Construtor 2: nome e preço
        public Produto(string nome, double preco) : this()
        {
            this.nome = nome;
            this.preco = preco;
            Console.WriteLine($"Construtor Produto(nome, preco) chamado: nome = {nome}, preco = {preco}");
        }

        // Construtor 3: nome, preço e quantidade
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)//reaproveitando o construtor acima
        {
            this.quantidade = quantidade;
            Console.WriteLine($"Construtor Produto(nome, preco, quantidade) chamado: quantidade = {quantidade}");
        }

        public override string ToString()
        {
            return $"Produto: {nome}, Preço: {preco}, Quantidade: {quantidade}";
        }
    }
}