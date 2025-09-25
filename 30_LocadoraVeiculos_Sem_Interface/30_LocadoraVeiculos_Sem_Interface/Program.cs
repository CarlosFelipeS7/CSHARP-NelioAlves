using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _30_LocadoraVeiculos_Sem_Interface.Entities;
using _30_LocadoraVeiculos_Sem_Interface.Services;

namespace _30_LocadoraVeiculos_Sem_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine( "Pickup (dd/MM/yyyy hh:mm" );
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM//yyyy hh:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM//yyyy hh:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per day");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            //instanciando objetos com base nos valores informados
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
