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

        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(duration.TotalHours<= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            //instanciando
            carRental.Invoice = new Invoice(basicPayment, tax);
        }

    }
}
