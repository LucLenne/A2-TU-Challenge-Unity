﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chien : Animal
    {
        public Chien(string name) 
        {
            Name = name;
            IsAlive = true;
            Pattes = 4;
        }
    }
}
