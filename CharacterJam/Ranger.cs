using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Ranger : IClass
    {
        public int HitDie { get { return 10; } }
        public string ArmorAndWeapons { get { return "Light and medium armor, shields, simple and martial weapons"; } }
        public string SavingThrow { get { return "Strength & Dexterity"; } }
        public override string ToString()
        {
            return "Ranger";
        }
    }
}

