using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Paladin : IClass
    {
        public int HitDie { get { return 10; } }
        public string ArmorAndWeapons { get { return "All armor, shields, simple and martial weapons"; } }
        public string SavingThrow { get { return"Wisdom & Charisma"; } }
        public override string ToString()
        {
            return "Paladin";
        }
    }
}
