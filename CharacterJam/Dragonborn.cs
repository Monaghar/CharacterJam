using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Dragonborn : IRace
    {
        public int StrBonus { get { return 2; } }
        public int DexBonus { get { return 0; } }
        public int ConBonus { get { return 0; } }
        public int IntBonus { get { return 0; } }
        public int WisBonus { get { return 0; } }
        public int ChaBonus { get { return 1; } }
        public int AgeRange { get { return 100; } }
        public int Speed { get { return 30; } }
        public string Size { get { return "Medium"; } }
        public string Language { get { return "Draconic, Common "; } }
        public override string ToString()
        {
            return "Dragonborn";
        }
    }
}
