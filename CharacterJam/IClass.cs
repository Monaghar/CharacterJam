using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public interface IClass
    {
        int HitDie { get; }
        string SavingThrow { get; }
        string ArmorAndWeapons { get; }
    }
}