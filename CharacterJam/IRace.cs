using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [StringLength(50)]
        string Size { get; }
        int AgeRange { get; }
        [StringLength(50)]
        string Language { get; }
        //ToDo figure out how to add Race traits
    }
}