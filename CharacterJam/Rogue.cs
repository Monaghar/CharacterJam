using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Rogue : IClass
    {
        public int HitDie { get { return 8; } }
        public string ArmorAndWeapons { get { return "Light armor, simple weapons, hand crossbows, longswords, rapiers, shortswords"; } }
        public string SavingThrow { get { return "Dexterity & Intelligence"; } }
        public override string ToString()
        {
            return "Rogue";
        }
    }
}
