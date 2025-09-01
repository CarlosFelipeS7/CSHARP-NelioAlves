using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Properties_Propriedades_
{
    class Produto 
    {

        private string _nome;
        public double Preco { get; private set; }//AutoProperties: forma mais simples de armazenar get e set; To dizendo que get é publico e set é privado da classe
        private int _quantidade; 

        //eu troco para private, para que apenas os metodos da classe possam definir um valor para quantidade
        // senao o programador poderia alterar como bem entender, 


        public Produto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this.Preco = preco;
            this._quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            this._nome = nome;
            this.Preco = preco;
            _quantidade = 0;
        }

      

        //Properties/Propriedade, utilizo o get e o set dentro desse escopo, 
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
           // value é uma palavra reservada para pegar o valor do parametro em properties
        }

       

        //Armazenanando get de quantidade em uma propertie
        public int Quantidade
        {

            get { return _quantidade; }

        }







        public double ValorTotalEstoque()
        {
            return Preco * _quantidade;
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
            return _nome
        + ", Preço: R$ " + Preco
        + ", Quantidade: " + _quantidade
        + ", Total: R$ " + ValorTotalEstoque();
        }


    }
}
