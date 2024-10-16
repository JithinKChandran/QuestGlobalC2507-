using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_StudentMark
{
    internal class Marks
    {
        public string SubjectName;
        public int Score;
        public int MaxMarks;

        public override string ToString()
        {
            return $"Subject: {SubjectName}, Score: {Score}/{MaxMarks}";
        }
    }
}
