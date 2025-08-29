using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Sintaxe_Alternativa_Instanciar_Objetos
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;




    


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
