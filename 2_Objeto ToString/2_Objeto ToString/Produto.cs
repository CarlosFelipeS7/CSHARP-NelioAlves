using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Objeto_ToString
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qte)
        {
            Quantidade += qte;


        }


        //Metodo para chamar os atributos do objeto utilizando apenas o nome da classe
        public override string ToString()
        {
          
                 return $"Nome: {Nome}\nPreço: $ {Preco}\nQuantidade: {Quantidade} unidades";
        }

    }
}
