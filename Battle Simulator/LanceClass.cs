using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Simulator
{
    class LanceClass
    {
        public string weaponName { get; set; }
        public int weaponDmg { get; set; }

        public LanceClass(string lance, int lanceDmg)
        {
            weaponName = lance;
            weaponDmg = lanceDmg;
        }
    }
}
