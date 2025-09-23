using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Try_Catch
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        
        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            this.RoomNumber = roomNumber;
            this.Checkin = checkin;
            this.Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin); //diferenca entre um instante e outro se torna a duracao
            //fazendo cast com duration para retornar a duracao em dias
            return (int)duration.TotalDays;

          
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            Checkin = checkIn;
            Checkout = checkOut;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in"
                + Checkin.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }

    }
}