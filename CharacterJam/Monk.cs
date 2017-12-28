using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Monk : IClass
    {
        public int HitDie { get { return HitDie; } private set { HitDie = 8; } }
        public string ArmorAndWeapons { get { return ArmorAndWeapons; } private set { ArmorAndWeapons = "Simple weapons, shortswords"; } }
        public string SavingThrow { get { return SavingThrow; } private set { SavingThrow = "Strength & Dexterity"; } }
        public override string ToString()
        {
            return "Monk";
        }
    }
}
