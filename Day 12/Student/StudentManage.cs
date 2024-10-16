using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class StudentManage
    {
        private List<Student> students = new List<Student>();
        public void Add(Student stud)
        {
            if (GetStudentById(stud.StudentId) != null)
            {
                Console.WriteLine("Student already exists");
                return;
            }

            students.Add(stud);
            Console.WriteLine("Added successfully");
        }
        public void Search(string StudentId)
        {
            var stud = GetStudentById(StudentId);
            Console.WriteLine(stud);
        }

        public void Update(string StudentId, string Class)
        {
            var studID = GetStudentById(StudentId);
            if (studID == null)
            {
                Console.WriteLine("Not found");
                return;
            }

            studID.ClassAndDivision = Class;
            Console.WriteLine("Updated successfully");
        }

        public void Delete(string StudentId)
        {
            var studID = GetStudentById(StudentId);
            if (studID == null)
            {
                Console.WriteLine("Not found");
                return;
            }

            students.Remove(studID);
            Console.WriteLine("Deleted successfully");
        }

        private Student GetStudentById(string StudentId)
        {
            foreach (var id in students)
            {
                if (id.StudentId == StudentId)
                {
                    return id;
                }
            }
            return null;
        }
    }
}
