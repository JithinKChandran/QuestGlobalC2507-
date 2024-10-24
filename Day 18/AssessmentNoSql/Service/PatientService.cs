using AssessmentNoSql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentNoSql.Service
{
    public class PatientService : EntityService
    {
        public override void AddPatient(Patient patient)
        {
            if (patient == null || string.IsNullOrWhiteSpace(patient.Name) || string.IsNullOrWhiteSpace(patient.MedicalCondition))
                throw new ArgumentException("Invalid patient data");

            patients.Add(patient);
        }

        public override void UpdatePatient(Patient patient)
        {
            var existingPatient = patients.Find(p => p.Id == patient.Id);
            if (existingPatient == null)
                throw new KeyNotFoundException("Patient not found");

            existingPatient.Name = patient.Name;
            existingPatient.Age = patient.Age;
            existingPatient.Gender = patient.Gender;
            existingPatient.MedicalCondition = patient.MedicalCondition;
        }

        public override void DeletePatient(int id)
        {
            var patient = patients.Find(p => p.Id == id);
            if (patient == null)
                throw new KeyNotFoundException("Patient not found");

            patients.Remove(patient);
        }

        public override List<Patient> GetAllPatients()
        {
            return patients;
        }

        public override void AddDoctor(Doctor doctor) { }
        public override void UpdateDoctor(Doctor doctor) { }
        public override void DeleteDoctor(int id) { }
        public override List<Doctor> GetAllDoctors() { return null; }
    }
}
