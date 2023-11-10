using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Poisson : Animal
    {
        public Poisson(string name) 
        {
            Name = name + " le poisson";
            IsAlive = true;
            Pattes = 0;
        }
    }
}
