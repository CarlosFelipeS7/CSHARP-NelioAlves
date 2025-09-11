using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Enum_com_Entidades.Entities.Enums
{
    
     enum OrderStatus : int //mudando a classe pra um enum int
    {
        PendingPayment = 0, 
        Processing = 1, 
        Shipped = 2, 
        Delivered = 3
    }
}
