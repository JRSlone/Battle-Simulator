using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Simulator
{
    class Player
    {
        public string Name { get; set; }
        public int Hp { get; set; }

        public Player(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }
        
    }
}
