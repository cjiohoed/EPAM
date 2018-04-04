using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DateTimeExtensions
    {
        public static int GetFullYears(DateTime dt)
        {
            DateTime dateNow = DateTime.Now;
            int fullYears = dateNow.Year - dt.Year;
            if (dateNow.Month < dt.Month || dateNow.Month == dt.Month & dateNow.Day < dt.Day)
            {
                fullYears--;
            }

            return fullYears;
        }

    }
}
