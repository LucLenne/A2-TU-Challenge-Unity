﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class ChatQuiBoite : Chat
    {
        public ChatQuiBoite(string v) : base (v)
        {
            Name = v;
            Pattes = 3;
        }
    }
}
