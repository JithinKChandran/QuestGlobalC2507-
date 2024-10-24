using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentNoSql.Entities
{
    public class Doctor
    {
        private string name;
        private string specialization;

        public int Id { get; set; }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");
                name = value;
            }
        }
        public string Specialization
        {
            get => specialization;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Specialization cannot be empty");
                specialization = value;
            }
        }
        public int PatientId { get; set; }
    }
}
