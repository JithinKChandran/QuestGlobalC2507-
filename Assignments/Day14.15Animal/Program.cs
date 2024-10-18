using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._15Animal
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.MakeSound();

            Animal dog = new Dog();
            dog.MakeSound();
        }
    }
}
