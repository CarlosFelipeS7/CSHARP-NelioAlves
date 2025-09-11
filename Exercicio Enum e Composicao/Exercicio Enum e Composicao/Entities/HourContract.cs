using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Enum_e_Composicao
{
    class HourContract
    {
        //propriedades
        public DateTime Date { get; set; }
        public double ValueHour { get; set; }
        public int Hours { get; set; }

        //construtor padrao
        public HourContract()
        {

        }

        //construtor 
        public HourContract(DateTime date, double valueHour, int hours)
        {
            Date = date;
            ValueHour = valueHour;
            Hours = hours;
        }

        //metodo
        public double TotalValue(){

            return Hours * ValueHour;
        
        }

    
    }


}
