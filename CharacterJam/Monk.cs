using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Monk : IClass
    {
        public int HitDie { get { return HitDie = 8; } private set {} }
        public string ArmorAndWeapons { get { return ArmorAndWeapons = "Simple weapons, shortswords"; } private set {} }
        public string SavingThrow { get { return SavingThrow = "Strength & Dexterity"; } private set {} }
        public override string ToString()
        {
            return "Monk";
        }
    }
}
