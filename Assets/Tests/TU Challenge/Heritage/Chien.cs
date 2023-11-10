using System;
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
            Feed = false;
        }

        public override string Crier()
        {
            if (Feed == false)
            {
                return "Ouaf (j'ai faim)";
            }
            else
            {
                return "Ouaf (viens on joue ?)";
            }
            
        }
    }
}
