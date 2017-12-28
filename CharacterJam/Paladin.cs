using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Paladin : IClass
    {
        public int HitDie { get { return HitDie; } private set { HitDie = 10; } }
        public string ArmorAndWeapons { get { return ArmorAndWeapons; } private set { ArmorAndWeapons = "All armor, shields, simple and martial weapons"; } }
        public string SavingThrow { get { return SavingThrow; } private set { SavingThrow = "Wisdom & Charisma"; } }
        public override string ToString()
        {
            return "Paladin";
        }
    }
}
