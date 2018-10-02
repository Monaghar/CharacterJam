using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Barbarian : IClass
    {

        public int HitDie { get { return 12; } }
        public string ArmorAndWeapons { get { return "Light and medium armor, shields, simple and martial weapons"; } }
        public string SavingThrow { get { return "Strength & Constitution";} }
        public override string ToString()
        {
            return "Barbarian";
        }
    }
}
