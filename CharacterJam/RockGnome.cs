using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class RockGnome : IRace
    {
        public int StrBonus { get { return 0; } }
        public int DexBonus { get { return 0; } }
        public int ConBonus { get { return 0; } }
        public int IntBonus { get { return 0; } }
        public int WisBonus { get { return 0; } }
        public int ChaBonus { get { return 0; } }
        public int AgeRange { get { return 500; } }
        public int Speed { get { return 25; } }
        public string Size { get { return "Small"; } }
        public string Language { get { return "Gnomish, Common "; } }
        public override string ToString()
        {
            return "Rock Gnome";
        }
    }
}
