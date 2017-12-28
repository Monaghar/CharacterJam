using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class StoutHalfling : IRace
    {
        public int StrBonus { get { return StrBonus; } private set { StrBonus = 0; } }
        public int DexBonus { get { return DexBonus; } private set { DexBonus = 2; } }
        public int ConBonus { get { return ConBonus; } private set { ConBonus = 1; } }
        public int IntBonus { get { return IntBonus; } private set { IntBonus = 0; } }
        public int WisBonus { get { return WisBonus; } private set { WisBonus = 0; } }
        public int ChaBonus { get { return ChaBonus; } private set { ChaBonus = 0; } }
        public int AgeRange { get { return AgeRange; } private set { AgeRange = 300; } }
        public int Speed { get { return Speed; } private set { Speed = 25; } }
        public string Size { get { return Size; } private set { Size = "Small"; } }
        public override string ToString()
        {
            return "Stout Halfling";
        }
    }
}
