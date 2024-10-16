using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        public string StudentName;
        public string StudentId;
        public string ClassAndDivision;
        public override string ToString()
        {
            return $"Student Name: {StudentName}, Student ID: {StudentId}, Class: {ClassAndDivision})";
        }
    }
}
