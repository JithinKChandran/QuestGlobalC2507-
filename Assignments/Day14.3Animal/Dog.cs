﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14._3Animal
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("bow");
        }
    }
}
