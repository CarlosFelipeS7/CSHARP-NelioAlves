using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Comparison_T
{
    internal class Produto 
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


     
    }
}
