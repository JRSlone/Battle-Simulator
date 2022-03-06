using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Simulator
{
    class Player
    {
        public string Name { get; set; } //Don't know how to add properly so just sitting here, replaced with direct user input in Combat.cs before the main while loop.
        public int Hp { get; set; }

        public Player(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }
        
    }
}
