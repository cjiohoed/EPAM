using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using Lib;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            General.Title("04.3");

            Culture.Display("ru-RU", "en-US");
            Culture.Display("en-US", "");
            Culture.Display("ru-RU", "");

            General.Goodbye();
        }
    }

    public class Culture
    {
        public static void Display(string culture1, string culture2)
        {
            var dt = DateTime.Now;
            var c1 = new CultureInfo(culture1);
            var c2 = new CultureInfo(culture2);
            double value = 12345.67890;

            Console.WriteLine($"{c1.TextInfo.CultureName}\t\t\t{c2.TextInfo.CultureName}");
            Console.WriteLine($"{dt.ToString("d", c1)}\t\t{dt.ToString("d", c2)}");
            Console.WriteLine($"{dt.ToString("t", c1)}\t\t\t{dt.ToString("t", c2)}");
            Console.WriteLine($"{value.ToString("C", c1)}\t\t{value.ToString("C", c2)}\n");
            
        }
    }
}
