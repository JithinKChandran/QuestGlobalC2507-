using AssessmentNoSql.Entities;
using AssessmentNoSql.Enum;
using AssessmentNoSql.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentNoSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doctorService = new DoctorService();
            var patientService = new PatientService();

            var newDoctor = new Doctor
            {
                Id = 1,
                Name = "Dr X",
                Specialization = "Cardio",
                PatientId = 1
            };
            doctorService.AddDoctor(newDoctor);

            var newPatient = new Patient
            {
                Id = 1,
                Name = "John",
                Age = 30,
                Gender = Gender.Male,
                MedicalCondition = "Healthy"
            };
            patientService.AddPatient(newPatient);

            var allDoctors = doctorService.GetAllDoctors();
            var allPatients = patientService.GetAllPatients();

            foreach (var doctor in allDoctors)
            {
                Console.WriteLine($"{doctor.Id}, {doctor.Name}, {doctor.Specialization}, {doctor.PatientId}");
            }

            foreach (var patient in allPatients)
            {
                Console.WriteLine($"{patient.Id}, {patient.Name}, {patient.Age}, {patient.Gender}, {patient.MedicalCondition}");
            }
        }
    }
}
