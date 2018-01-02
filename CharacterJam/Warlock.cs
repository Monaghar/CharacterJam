using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Warlock : IClass
    {
        public int HitDie { get { return HitDie = 6; } private set {} }
        public string ArmorAndWeapons { get { return ArmorAndWeapons = "Light armor, simple weapons"; } private set {} }
        public string SavingThrow { get { return SavingThrow = "Wisdom & Charisma"; } private set {} }
        public override string ToString()
        {
            return "Warlock";
        }
    }
}
