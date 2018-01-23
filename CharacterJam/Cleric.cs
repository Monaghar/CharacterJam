using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Cleric : IClass
    {
        public int HitDie { get { return 8; } }
        public string ArmorAndWeapons { get { return "Light and medium armor, shields, simple weapons"; } }
        public string SavingThrow { get { return "Wisdom & Charisma"; } }
        public override string ToString()
        {
            return "Cleric";
        }
    }
}
