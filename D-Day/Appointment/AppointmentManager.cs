using System;
using System.Collections.Generic;
using System.Linq;

namespace Appointment
{
    public class AppointmentManager
    {
        private const int StartHour = 9;
        private const int EndHour = 17;
        private List<Appointment> appointments = new List<Appointment>();

        public bool BookAppointment(string patientName, DateTime startTime, DateTime endTime)
        {
            if (!IsSlotAvailable(startTime, endTime) || !IsWorkingTime(startTime, endTime))
            {
                return false;
            }

            appointments.Add(new Appointment
            {
                StartTime = startTime,
                EndTime = endTime,
                PatientName = patientName,
            });

            return true;
        }

        public List<Appointment> GetAppointments()
        {
            return new List<Appointment>(appointments);
        }

        private bool IsSlotAvailable(DateTime startTime, DateTime endTime)
        {
            return !appointments.Any(a => a.StartTime < endTime && a.EndTime > startTime);
        }

        public bool IsWorkingTime(DateTime startTime, DateTime endTime)
        {
            return startTime.Hour >= StartHour && endTime.Hour <= EndHour;
        }
    }
}
