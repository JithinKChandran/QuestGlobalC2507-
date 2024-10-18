using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._16EmployeeBonus
{
    public class Employee
    {
        public virtual int CalculateBonus(int sal)
        {
            return sal + 1000;
        }
    }

    public class Manager : Employee
    {
        public override int CalculateBonus(int sal)
        {
            return sal + 1500;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            int bonus = e.CalculateBonus(20000);

            Employee manager = new Manager();
            int mbonus = manager.CalculateBonus(25000);

            Console.WriteLine($" Employee: {bonus} | Manager: {mbonus}");
        }
    }
}
