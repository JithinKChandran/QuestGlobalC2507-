using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    /*class Student
    {
        public string Name;

        public void DisplayName()
        {
            Console.WriteLine("Hi" + Name);
        }
    }*/

    /* class Employee
       {
         public string FirstName;
         public string LastName;
         public int Salary;

         public void DisplayAnnualSalary()
         {
             Console.WriteLine($"Annual Salary : {Salary * 12}");
         }
       }*/

    class Student
    {
        public string Name;
        public float Mark1;
        public float Mark2;
        public float Mark3;
        public float Total;

        public void FindTotalMarks()
        {
            Total = Mark1 + Mark2 + Mark3;
            Console.WriteLine($"Total marks : {Total}");
        }

        public void FindAvgMarks()
        {
            float avg = Total / 3;
            Console.WriteLine($"Average marks : {avg}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();
            student1.Name = "Ali";
            student1.Mark1 = 10;
            student1.Mark2 = 20;
            student1.Mark3 = 30;

            student1.FindTotalMarks();
            student1.FindAvgMarks();


            /*Student s = new Student();
            s.Name = "abhi";

            Student s1 = new Student();
            s1.Name = "aadhi";*/

            /*Employee e1 = new Employee();
            e1.FirstName = "Job";
            e1.LastName = "jphn";
            e1.Salary = 20000;

            e1.DisplayAnnualSalary();*/

        }
    }
}
