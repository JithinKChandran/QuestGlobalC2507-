﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Minesweeper game = new Minesweeper();
            game.Play();
        }
    }
}
