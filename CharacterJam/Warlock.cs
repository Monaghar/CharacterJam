using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Warlock : IClass
    {
        public int HitDie { get { return 6; } }
        public string ArmorAndWeapons { get { return "Light armor, simple weapons"; } }
        public string SavingThrow { get { return "Wisdom & Charisma"; } }
        public override string ToString()
        {
            return "Warlock";
        }
    }
}
