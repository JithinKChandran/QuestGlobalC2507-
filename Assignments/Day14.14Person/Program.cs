using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._14Person
{
    public abstract class Person
    {
        public abstract void Work();
    }

    public class Doctor : Person
    {
        public override void Work()
        {
            Console.WriteLine("Doc");
        }
    }
    public class Engineer : Person
    {
        public override void Work()
        {
            Console.WriteLine("Eng");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person doc = new Doctor();
            doc.Work();
            Person eng = new Engineer();
            eng.Work();
        }
    }
}
