﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player (string name)
        {
            Name = name;
            Score = 0;
        }
    }
}
