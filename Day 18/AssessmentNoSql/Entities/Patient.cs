using AssessmentNoSql.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentNoSql.Entities
{
    public class Patient
    {
        private string name;
        private string medicalCondition;

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
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string MedicalCondition
        {
            get => medicalCondition;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Medical Condition cannot be empty");
                medicalCondition = value;
            }

        }
    }
}
