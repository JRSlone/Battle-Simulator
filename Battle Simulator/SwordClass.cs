using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Simulator
{
    public class SwordClass
    {
        public string weaponName { get; set; }
        public int weaponDmg { get; set; }

        public SwordClass(string sword, int swordDmg)
        {
            weaponName = sword;
            weaponDmg = swordDmg;
        }
    } 
}
