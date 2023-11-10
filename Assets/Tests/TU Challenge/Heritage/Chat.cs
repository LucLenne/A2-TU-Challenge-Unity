using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace TU_Challenge.Heritage
{
    public class Chat : Animal
    {

        public Chat(string v)
        {
            Name = v;
            IsAlive= true;
            Pattes = 4;
        }
    }
}
