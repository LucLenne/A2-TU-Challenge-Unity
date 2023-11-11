using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            IsAlive = true;
            Pattes = 4;
            Feed = false;
            FeedFish = false;

        }
        public override string Crier()
        {
            if(Feed == false)
            {
                return "Miaou (j'ai faim)";
            }
            else if(FeedFish == true)
            {
                return "Miaou (Le poisson etait bon)";
            }
            else 
            {
                return "Miaou (c'est bon laisse moi tranquille humain)";
            }
            
        }
    }
}
