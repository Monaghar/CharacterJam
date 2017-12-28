﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class HalfElf : IRace
    {
        // also pick two other stats by 1
        public int StrBonus { get { return StrBonus; } private set { StrBonus = 0; } }
        public int DexBonus { get { return DexBonus; } private set { DexBonus = 0; } }
        public int ConBonus { get { return ConBonus; } private set { ConBonus = 0; } }
        public int IntBonus { get { return IntBonus; } private set { IntBonus = 0; } }
        public int WisBonus { get { return WisBonus; } private set { WisBonus = 0; } }
        public int ChaBonus { get { return ChaBonus; } private set { ChaBonus = 2; } }
        public int AgeRange { get { return AgeRange; } private set { AgeRange = 250; } }
        public int Speed { get { return Speed; } private set { Speed = 30; } }
        public string Size { get { return Size; } private set { Size = "Medium"; } }
        public override string ToString()
        {
            return "Half Elf";
        }
    }
}
