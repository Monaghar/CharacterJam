using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Druid : IClass
    {
        public int HitDie { get { return HitDie; } private set { HitDie = 8; } }
        public string ArmorAndWeapons { get { return ArmorAndWeapons; } private set { ArmorAndWeapons = "Light and medium armor (nonmetal), shields(nonmetal), " +
                                                                                                        "clubs, daggers, darts, javelins, maces, quarterstaffs, " +
                                                                                                        "scimitars, sickles, slings, spears"; } }
        public string SavingThrow { get { return SavingThrow; } private set { SavingThrow = "Intelligence & Wisdom"; } }
        public override string ToString()
        {
            return "Druid";
        }
    }
}
