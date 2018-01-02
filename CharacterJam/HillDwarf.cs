﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class HillDwarf : IRace
    {
        public int StrBonus { get { return StrBonus = 0; } private set {} }
        public int DexBonus { get { return DexBonus = 0; } private set {} }
        public int ConBonus { get { return ConBonus = 2; } private set {} }
        public int IntBonus { get { return IntBonus = 0; } private set {} }
        public int WisBonus { get { return WisBonus = 1; } private set {} }
        public int ChaBonus { get { return ChaBonus = 0; } private set {} }
        public int AgeRange { get { return AgeRange = 425; } private set {} }
        public int Speed { get { return Speed = 25; } private set {} }
        public string Size { get { return Size = "Medium"; } private set {} }
        public override string ToString()
        {
            return "Hill Dwarf";
        }
    }
}
