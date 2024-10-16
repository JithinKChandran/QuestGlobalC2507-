using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sManage = new StudentManage();

            while (true)
            {
                Console.WriteLine("1. Add student ");
                Console.WriteLine("2. Search student by regId");
                Console.WriteLine("3. Update student detail");
                Console.WriteLine("4. Delete student entry");
                var c = Console.ReadLine();

                switch (c)
                {
                    case "1":
                        var stud = GetStudent();
                        sManage.Add(stud);
                        break;
                    case "2":
                        Console.WriteLine("Enter student id to search: ");
                        var studentId = Console.ReadLine();
                        sManage.Search(studentId);
                        break;
                    case "3":
                        var studentToUpdate = GetStudent();
                        sManage.Update(studentToUpdate.StudentId,
                        studentToUpdate.ClassAndDivision);
                        break;
                    case "4":
                        Console.WriteLine("Enter the student id to delete:");
                        var studToDelete = Console.ReadLine();
                        sManage.Delete(studToDelete);
                        break;
                    default:
                        Console.WriteLine("INVALID");
                        break;
                }
            }
        }

        private static Student GetStudent()
        {
            Student stud = new Student();

            Console.WriteLine("Enter student name : ");
            stud.StudentName = Console.ReadLine();

            Console.WriteLine("Enter the student id");
            stud.StudentId = Console.ReadLine();

            Console.WriteLine("Enter the class and division");
            stud.ClassAndDivision = Console.ReadLine();
            return stud;
        }
    }
}
