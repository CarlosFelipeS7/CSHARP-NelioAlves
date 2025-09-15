using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Polimorfismo.Entities
{
     class Terceirizado: Funcionario
    {
        //acrescentando o que a classe terceirizado tem a mais que funcionario
        public double DespesaAdicional { get; set; }


        public Terceirizado()
        {

        }


        public Terceirizado(double despesaAdicional, string nome, int horas, double valorPorHora)
            :base( nome, horas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

       

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1* DespesaAdicional;

        }

    }


}
