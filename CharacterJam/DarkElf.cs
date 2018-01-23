using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class DarkElf : IRace
    {
        public int StrBonus { get { return 0; } }
        public int DexBonus { get { return 2; } }
        public int ConBonus { get { return 0; } }
        public int IntBonus { get { return 0; } }
        public int WisBonus { get { return 0; } }
        public int ChaBonus { get { return 1; } }
        public int AgeRange { get { return 800; } }
        public int Speed { get { return 30; } }
        public string Size { get { return "Medium"; } }
        public override string ToString()
        {
            return "Dark Elf";
        }
    }
}
