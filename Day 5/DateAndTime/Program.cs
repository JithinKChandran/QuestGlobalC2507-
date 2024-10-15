using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Local date and time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // UTC Time
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);

            Console.WriteLine($"Day: {dt.Day}");
            Console.WriteLine($"Month: {dt.Month}");
            Console.WriteLine($"Year: {dt.Year}");

            Console.WriteLine($"Hour: {dt.Hour}");
            Console.WriteLine($"Minute: {dt.Minute}");
            Console.WriteLine($"Second: {dt.Second}");
            Console.WriteLine($"Millisecond: {dt.Millisecond}");

            // Date time operations
            var tenDaysFromNow = dt.AddDays(10);
            Console.WriteLine(tenDaysFromNow);

            var tenDayAndTwentyHoursFRomNow = dt.AddHours(20).AddDays(10);
            Console.WriteLine(tenDayAndTwentyHoursFRomNow);

            //Formating the output

            Console.WriteLine();
            Console.WriteLine($"Standard Output: {dt}");
            Console.WriteLine(dt.ToString("dd-MM-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MMMM/dd/yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyyy"));
            Console.WriteLine(dt.ToString("HH:mm:ss"));

            // Constructing Date Time
            var myDt = new DateTime(2024, 10, 7, 12, 50, 50);
            Console.WriteLine($"My Date and time:{myDt}");
        }
    }
}
