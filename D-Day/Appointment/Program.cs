using System;
using System.Globalization;

namespace Appointment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new AppointmentManager();

            BookAndPrintResult(manager, "Ravi", "12-11-2024 10:00", "12-11-2024 11:00");
            BookAndPrintResult(manager, "Anjali", "12-11-2024 10:30", "12-11-2024 11:30");
            BookAndPrintResult(manager, "bheam", "12-11-2024 16:00", "12-11-2024 17:00");

            PrintScheduledAppointments(manager);
        }

        private static void BookAndPrintResult(AppointmentManager manager, string patientName, string start, string end)
        {
            var format = "dd-MM-yyyy HH:mm";
            DateTime startTime = DateTime.ParseExact(start, format, CultureInfo.InvariantCulture);
            DateTime endTime = DateTime.ParseExact(end, format, CultureInfo.InvariantCulture);
            bool result = manager.BookAppointment(patientName, startTime, endTime);
            if (result)
            {
                Console.WriteLine($"Booking appointment for {patientName} from {startTime:HH:mm} to {endTime:HH:mm}: " + ("Success"));
            }
            else
            {
                Console.WriteLine($"Booking appointment for {patientName} from {startTime:HH:mm} to {endTime:HH:mm}: " + ("Failed"));
            }
        }

        private static void PrintScheduledAppointments(AppointmentManager manager)
        {
            var scheduledAppointments = manager.GetAppointments();
            Console.WriteLine("\nScheduled Appointments:");
            foreach (var appointment in scheduledAppointments)
            {
                Console.WriteLine($"{appointment.PatientName}: {appointment.StartTime:dd-MM-yyyy HH:mm} - {appointment.EndTime:dd-MM-yyyy HH:mm}");
            }
        }
    }
}
