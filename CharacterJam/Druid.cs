using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Druid : IClass
    {
        public int HitDie { get { return 8; } }
        public string ArmorAndWeapons { get { return "Light and medium armor (nonmetal), shields(nonmetal), " +
                                                     "clubs, daggers, darts, javelins, maces, quarterstaffs, " +
                                                     "scimitars, sickles, slings, spears";} }

        public string SavingThrow { get { return "Intelligence & Wisdom"; } }
        public override string ToString()
        {
            return "Druid";
        }
    }
}
