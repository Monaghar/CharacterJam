using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public interface IRace
    {
        int StrBonus { get; }
        int DexBonus { get; }
        int ConBonus { get; }
        int WisBonus { get; }
        int IntBonus { get; }
        int ChaBonus { get; }
        int Speed { get; }
        string Size { get; }
        int AgeRange { get; }

        //ToDo figure out how to add Race traits
    }
}