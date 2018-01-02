﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Human : IRace
    {
        public int StrBonus { get { return StrBonus; } private set { StrBonus = 1; } }
        public int DexBonus { get { return DexBonus; } private set { DexBonus = 1; } }
        public int ConBonus { get { return ConBonus; } private set { ConBonus = 1; } }
        public int IntBonus { get { return IntBonus; } private set { IntBonus = 1; } }
        public int WisBonus { get { return WisBonus; } private set { WisBonus = 1; } }
        public int ChaBonus { get { return ChaBonus; } private set { ChaBonus = 1; } }
        public int AgeRange { get { return AgeRange; } private set { AgeRange = 100; } }
        public int Speed { get { return Speed; } private set { Speed = 30; } }
        public string Size { get { return Size; } private set { Size = "Medium"; } }
        public override string ToString()
        {
            return "Human";
        }

    }
}