using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Ranger : IClass
    {
        public int HitDie { get { return HitDie; } private set { HitDie = 10; } }
        public string ArmorAndWeapons { get { return ArmorAndWeapons; } private set { ArmorAndWeapons = "Light and medium armor, shields, simple and martial weapons"; } }
        public string SavingThrow { get { return SavingThrow; } private set { SavingThrow = "Strength & Dexterity"; } }
        public override string ToString()
        {
            return "Ranger";
        }
    }
}

