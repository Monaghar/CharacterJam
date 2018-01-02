using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Rogue : IClass
    {
        public int HitDie { get { return HitDie = 8; } private set {} }
        public string ArmorAndWeapons { get { return ArmorAndWeapons = "Light armor, simple weapons, hand crossbows, longswords, rapiers, shortswords"; } private set {} }
        public string SavingThrow { get { return SavingThrow = "Dexterity & Intelligence"; } private set {} }
        public override string ToString()
        {
            return "Rogue";
        }
    }
}
