using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Ranger : IClass
    {
        public int HitDie { get { return HitDie = 10; } private set {} }
        public string ArmorAndWeapons { get { return ArmorAndWeapons = "Light and medium armor, shields, simple and martial weapons"; } private set {} }
        public string SavingThrow { get { return SavingThrow = "Strength & Dexterity"; } private set {} }
        public override string ToString()
        {
            return "Ranger";
        }
    }
}

