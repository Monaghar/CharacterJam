using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Bard : IClass
    {
        public int HitDie { get { return HitDie; } private set { HitDie = 8; } }
        public string ArmorAndWeapons { get { return ArmorAndWeapons; } private set { ArmorAndWeapons = "Light armor, simple weapons, hand crossbows, longswords, rapiers, shortswords"; } }
        public string SavingThrow { get { return SavingThrow; } private set { SavingThrow = "Dexterity & Charisma"; } }
        public override string ToString()
        {
            return "Barbarian";
        }
    }
}
