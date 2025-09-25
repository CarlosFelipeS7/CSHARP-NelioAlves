using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _30_LocadoraVeiculos_Sem_Interface.Entities;

namespace _30_LocadoraVeiculos_Sem_Interface.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; } //adicionando restricao, so posso obter, nao posso modificar em outras classes
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {

        }

    }
}
