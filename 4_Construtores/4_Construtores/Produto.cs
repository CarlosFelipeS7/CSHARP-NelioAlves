using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Construtores
{
     class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        //Construtor:Obriga no momento que um objeto é instanciado informar nome, preco e quantidade; 
        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double ValorTotalEstoque()
        {
            return preco * quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            this.quantidade += quantidade;
        }


        public void RemoverProduto(int quantidade)
        {
            this.quantidade -= quantidade;
        }


        public override string ToString()
        {
            return nome
        + ", Preço: R$ " + preco
        + ", Quantidade: " + quantidade
        + ", Total: R$ " + ValorTotalEstoque();
        }


    }
}
