using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Cleric : IClass
    {
        public int HitDie { get { return HitDie; } private set { HitDie = 8; } }
        public string ArmorAndWeapons { get { return ArmorAndWeapons; } private set { ArmorAndWeapons = "Light and medium armor, shields, simple weapons"; } }
        public string SavingThrow { get { return SavingThrow; } private set { SavingThrow = "Wisdom & Charisma"; } }
        public override string ToString()
        {
            return "Cleric";
        }
    }
}
