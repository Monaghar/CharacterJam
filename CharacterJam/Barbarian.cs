using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Barbarian : IClass
    {

        public int HitDie { get { return HitDie = 12; } private set {} }
        public string ArmorAndWeapons { get { return ArmorAndWeapons = "Light and medium armor, shields, simple and martial weapons"; } private set {} }
        public string SavingThrow { get { return SavingThrow = "Strength & Constitution";} private set {} }
        public override string ToString()
        {
            return "Barbarian";
        }
    }
}
