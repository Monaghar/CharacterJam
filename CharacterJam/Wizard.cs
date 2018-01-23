using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Wizard : IClass
    {
        public int HitDie { get { return 6; } }
        public string ArmorAndWeapons { get { return "Daggers, darts, slings, quarterstaffs, light crossbows"; } }
        public string SavingThrow { get { return "Intelligence & Wisdom"; } }
        public override string ToString()
        {
            return "Wizard";
        }
    }
}
