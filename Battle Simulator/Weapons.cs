using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Simulator
{
    class Weapons //not included in anything yet still needs set up.
    {
        List<string> allWeapons = new List<string>();

        public Weapons()
        {
            allWeapons.Add("Sword");
            allWeapons.Add("Axe");
            allWeapons.Add("Lance");
        }


        // so make a weapon class that has this stuff in it defining this. 
        // set up a weapons class that has a list of weapons as well as what defeats what like sword beating axe
        //public string weaponName { get; set; } //can i be this generic or do i need multiple for each weapon? probably can get by with one generic just not sure how yet.
        //public int swordDmg { get; set; } //might be able to get by with only one "weaponDmg"
        //public int axeDmg { get; set; }
        //public int lanceDmg { get; set; }

        //public Weapons(string WpnName, int SwdDmg, int axDmg, int lncDmg)
        //{
        //    weaponName = WpnName;
        //    swordDmg = SwdDmg;
        //    axeDmg = axDmg;
        //    lanceDmg = lncDmg;
        //}
    } 
}
