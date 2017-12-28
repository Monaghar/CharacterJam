using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Barbarian : IClass
    {

        public int HitDie { get { return HitDie; } private set { HitDie = 12; } }
        public string ArmorAndWeapons { get { return ArmorAndWeapons; } private set { ArmorAndWeapons = "Light and medium armor, shields, simple and martial weapons"; } }
        public string SavingThrow { get { return SavingThrow; } private set { SavingThrow = "Strength & Constitution"; } }
        public override string ToString()
        {
            return "Barbarian";
        }
    }
}
