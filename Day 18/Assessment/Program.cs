using Assessment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Program
    {
        static string connStr = @"Data Source=ASUS; Database=QuestDB;Integrated Security=True";
        static void Main(string[] args)
        {
            PatientService patientService = new PatientService(connStr);
            DoctorService doctorService = new DoctorService(connStr);

            patientService.Add();
            patientService.GetAll();

            doctorService.Add();
            doctorService.GetAll();
        }
    }
}
