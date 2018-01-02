using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Druid : IClass
    {
        public int HitDie { get { return HitDie = 8; } private set {} }
        public string ArmorAndWeapons { get { return ArmorAndWeapons = "Light and medium armor (nonmetal), shields(nonmetal), " +
                                                                       "clubs, daggers, darts, javelins, maces, quarterstaffs, " +
                                                                       "scimitars, sickles, slings, spears";} private set { }}

        public string SavingThrow { get { return SavingThrow = "Intelligence & Wisdom"; } private set {} }
        public override string ToString()
        {
            return "Druid";
        }
    }
}
