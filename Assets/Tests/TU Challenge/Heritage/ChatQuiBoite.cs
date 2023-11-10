using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class ChatQuiBoite : Animal
    {
        public ChatQuiBoite(string v)
        {
            Chat chat = new Chat(v);
            Name = v;
            IsAlive = true;
            Pattes = 3;
        }
    }
}
