using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-OUT date (dd/MM/yyyy) ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation; Check-out date must be after check-in ");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to uptade the reservation: ");
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                 checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-OUT date (dd/MM/yyyy) ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if(checkIn< now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for uptade must be future dates ");
                }
                else if(checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation; Check-out date must be after check-in ");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation " + reservation);
                }

            }

        }
    }
}
