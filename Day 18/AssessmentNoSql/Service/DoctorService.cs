using AssessmentNoSql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentNoSql.Service
{
    public class DoctorService : EntityService
    {
        public override void AddDoctor(Doctor doctor)
        {
            if (doctor == null || string.IsNullOrWhiteSpace(doctor.Name) || string.IsNullOrWhiteSpace(doctor.Specialization))
                throw new ArgumentException("Invalid doctor data");

            doctors.Add(doctor);
        }

        public override void UpdateDoctor(Doctor doctor)
        {
            var existingDoctor = doctors.Find(d => d.Id == doctor.Id);
            if (existingDoctor == null)
                throw new KeyNotFoundException("Doctor not found");

            existingDoctor.Name = doctor.Name;
            existingDoctor.Specialization = doctor.Specialization;
        }

        public override void DeleteDoctor(int id)
        {
            var doctor = doctors.Find(d => d.Id == id);
            if (doctor == null)
                throw new KeyNotFoundException("Doctor not found");

            doctors.Remove(doctor);
        }

        public override List<Doctor> GetAllDoctors()
        {
            return doctors;
        }
        public override void AddPatient(Patient patient) { }
        public override void UpdatePatient(Patient patient) { }
        public override void DeletePatient(int id) { }
        public override List<Patient> GetAllPatients() { return null; }
    }
}
