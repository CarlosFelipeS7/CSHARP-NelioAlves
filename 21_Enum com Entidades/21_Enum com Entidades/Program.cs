using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _21_Enum_com_Entidades.Entities; //importei a classe 
using _21_Enum_com_Entidades.Entities.Enums; //importei a classe 

namespace _21_Enum_com_Entidades
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //convertendo pra string 
            string txt = OrderStatus.PendingPayment.ToString();

            //imprimindo PendingPayment no formato de String
            Console.WriteLine(txt);
            
            //fazendo cast para Enum
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            Console.WriteLine(os);


        }
    }
}
