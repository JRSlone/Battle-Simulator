using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Simulator
{
    class AxeClass
    {
        public string weaponName { get; set; }
        public int weaponDmg { get; set; }

        public AxeClass(string axe, int axeDmg)
        {
            weaponName = axe;
            weaponDmg = axeDmg;
        }
    }
}
