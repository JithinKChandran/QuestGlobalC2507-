using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_StudentMark
{
    internal class Student
    {
        public string StudentName;
        public string StudentId;
        public string ClassAndDivision;
        public List<Marks> marks = new List<Marks>();

        public override string ToString()
        {
            return $"Student Name: {StudentName}, Student ID: {StudentId}, Class: {ClassAndDivision}";

        }
    }
}
