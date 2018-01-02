using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Sorcerer : IClass
    {
        public int HitDie { get { return HitDie; } private set { HitDie = 6; } }
        public string ArmorAndWeapons { get { return ArmorAndWeapons; } private set { ArmorAndWeapons = "Daggers, darts, slings, quarterstaffs, light crossbows"; } }
        public string SavingThrow { get { return SavingThrow; } private set { SavingThrow = "Constitution & Charisma"; } }
        public override string ToString()
        {
            return "Sorcerer";
        }
    }
}
