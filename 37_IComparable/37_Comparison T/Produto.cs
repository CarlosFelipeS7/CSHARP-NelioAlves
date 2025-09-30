using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_IComparable
{
    internal class Produto: IComparable<Produto>
    {
        public double preco { get; set; }
        public string nome { get; set; }

        public Produto()
        {

        }

        public Produto(double preco, string nome)
        {
            this.preco = preco;
            this.nome = nome;
        }

        //override no metodo ToString para "personaliza-lo"
        public override string ToString()
        {
            return nome + " , " + preco.ToString("F2", CultureInfo.InvariantCulture);
        }


        public int CompareTo(Produto other)
        {
            return preco.CompareTo(other.preco);
        }
    }
}
