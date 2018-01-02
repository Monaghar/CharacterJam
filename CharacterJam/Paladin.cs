using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Paladin : IClass
    {
        public int HitDie { get { return HitDie = 10; } private set {} }
        public string ArmorAndWeapons { get { return ArmorAndWeapons = "All armor, shields, simple and martial weapons"; } private set {} }
        public string SavingThrow { get { return SavingThrow = "Wisdom & Charisma"; } private set {} }
        public override string ToString()
        {
            return "Paladin";
        }
    }
}
