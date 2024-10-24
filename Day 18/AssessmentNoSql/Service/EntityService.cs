using AssessmentNoSql.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentNoSql.Service
{
    public abstract class EntityService
    {
        protected List<Doctor> doctors = new List<Doctor>();
        protected List<Patient> patients = new List<Patient>();

        public abstract void AddDoctor(Doctor doctor);
        public abstract void UpdateDoctor(Doctor doctor);
        public abstract void DeleteDoctor(int id);
        public abstract List<Doctor> GetAllDoctors();

        public abstract void AddPatient(Patient patient);
        public abstract void UpdatePatient(Patient patient);
        public abstract void DeletePatient(int id);
        public abstract List<Patient> GetAllPatients();
    }
}
