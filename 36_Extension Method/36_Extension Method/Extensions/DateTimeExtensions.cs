using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Extension_Method.Extensions
{
   static class DateTimeExtensions
    {
        //criando extensions methods
        public static string ElapsedTime(this DateTime esseObjeto) //esse parametro define extension method
        {
            TimeSpan duration = DateTime.Now.Subtract(esseObjeto);

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas ";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days ";
            }
             
        }


    }
}
