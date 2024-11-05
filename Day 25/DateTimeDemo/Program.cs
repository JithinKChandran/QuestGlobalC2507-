using System;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime specificDate = new DateTime(2024, 11, 5);
            DateTime specificDateTime = new DateTime(2024, 11, 5, 14, 30, 0);
            Console.WriteLine("Now: " + now);
            Console.WriteLine("Today: " + today);
            Console.WriteLine("Specific Date: " + specificDate);
            Console.WriteLine("Specific DateTime: " + specificDateTime);

            // Accessing various properties
            Console.WriteLine("Year: " + now.Year);
            Console.WriteLine("Month: " + now.Month);
            Console.WriteLine("Day: " + now.Day);
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine("Second: " + now.Second);
            Console.WriteLine("Millisecond: " + now.Millisecond);
            Console.WriteLine("Day of Week: " + now.DayOfWeek);
            Console.WriteLine("Day of Year: " + now.DayOfYear);

            // Adding and subtracting time
            DateTime tomorrow = now.AddDays(1);
            DateTime nextMonth = now.AddMonths(1);
            DateTime nextYear = now.AddYears(1);
            DateTime oneHourLater = now.AddHours(1);
            DateTime tenMinutesEarlier = now.AddMinutes(-10);
            Console.WriteLine("Tomorrow: " + tomorrow);
            Console.WriteLine("Next Month: " + nextMonth);
            Console.WriteLine("Next Year: " + nextYear);
            Console.WriteLine("One Hour Later: " + oneHourLater);
            Console.WriteLine("Ten Minutes Earlier: " + tenMinutesEarlier);

            // TimeSpan and differences
            TimeSpan difference = now - specificDate;
            Console.WriteLine("\nTimeSpan and Differences:");
            Console.WriteLine("Difference in Days: " + difference.Days);
            Console.WriteLine("Difference in Hours: " + difference.TotalHours);

            // Formatting DateTime
            Console.WriteLine("\nFormatting DateTime:");
            Console.WriteLine("ToString: " + now.ToString());
            Console.WriteLine("Short Date: " + now.ToShortDateString());
            Console.WriteLine("Long Date: " + now.ToLongDateString());
            Console.WriteLine("Short Time: " + now.ToShortTimeString());
            Console.WriteLine("Long Time: " + now.ToLongTimeString());
            Console.WriteLine("Custom Format: " + now.ToString("yyyy-MM-dd HH:mm:ss"));

            // Parsing DateTime
            string dateString = "2024-11-05";
            DateTime parsedDate = DateTime.Parse(dateString);
            Console.WriteLine("\nParsing DateTime:");
            Console.WriteLine("Parsed Date: " + parsedDate);

            // TryParse DateTime
            string invalidDateString = "invalid date";
            if (DateTime.TryParse(invalidDateString, out DateTime tryParsedDate))
            {
                Console.WriteLine("TryParsed Date: " + tryParsedDate);
            }
            else
            {
                Console.WriteLine("Failed to parse date: " + invalidDateString);
            }
        }
    }
}
