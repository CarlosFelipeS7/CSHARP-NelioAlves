using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _21_Enum_com_Entidades.Entities.Enums; //importei a classe 

namespace _21_Enum_com_Entidades.Entities
{
     class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()//SobreEscrita
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;

        }
       
    }
}
