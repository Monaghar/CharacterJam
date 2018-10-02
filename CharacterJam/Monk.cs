using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Monk : IClass
    {
        public int HitDie { get { return 8; } }
        public string ArmorAndWeapons { get { return "Simple weapons, shortswords"; } }
        public string SavingThrow { get { return "Strength & Dexterity"; } }
        public override string ToString()
        {
            return "Monk";
        }
    }
}
