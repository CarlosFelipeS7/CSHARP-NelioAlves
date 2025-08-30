using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Encapsulamento
{
    class Produto
    {
        public string nome;
        public double preco;
        private int _quantidade; //padrao do C#, atributo privado comecar com _
        
        //eu troco para private, para que apenas os metodos da classe possam definir um valor para quantidade
        // senao o programador poderia alterar como bem entender, 
      

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this._quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            _quantidade = 0; 
        }

        public int GetQuantidade() //Para exibit atributos privates
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)//Set para alterar atributos privados
        {
            _quantidade = quantidade;
        }


        public double ValorTotalEstoque()
        {
            return preco * _quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            this._quantidade += quantidade;
        }


        public void RemoverProduto(int quantidade)
        {
            this._quantidade -= quantidade;
        }


        public override string ToString()
        {
            return nome
        + ", Preço: R$ " + preco
        + ", Quantidade: " + _quantidade
        + ", Total: R$ " + ValorTotalEstoque();
        }


    }
}
