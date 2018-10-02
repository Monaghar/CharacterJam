using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Sorcerer : IClass
    {
        public int HitDie { get { return HitDie = 6; } private set {} }
        public string ArmorAndWeapons { get { return ArmorAndWeapons = "Daggers, darts, slings, quarterstaffs, light crossbows"; } private set {} }
        public string SavingThrow { get { return SavingThrow = "Constitution & Charisma"; } private set {} }
        public override string ToString()
        {
            return "Sorcerer";
        }
    }
}
