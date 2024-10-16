using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_StudentMark
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
                Console.WriteLine("5. Add mark for a student");  // New option to add marks
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
                    case "5": 
                        Console.WriteLine("Enter student id to add marks: ");
                        var studentMarkId = Console.ReadLine();
                        var marks = GetMarks();
                        var student = sManage.GetStudentById(studentMarkId);
                        if (student != null)
                        {
                            student.marks.Add(marks);
                            Console.WriteLine("Marks added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Student not found");
                        }
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

        private static Marks GetMarks()
        {
            Marks mark = new Marks();
            Console.WriteLine("Enter subject name : ");
            mark.SubjectName = Console.ReadLine();
            Console.WriteLine("Enter the obtained mark : ");
            mark.Score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum mark : ");
            mark.MaxMarks = Convert.ToInt32(Console.ReadLine());
            return mark;
        }
    }
}
