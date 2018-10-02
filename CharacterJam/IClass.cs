using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public interface IClass
    {
        int HitDie { get; }
        [StringLength(100)]
        string SavingThrow { get; }
        [StringLength(100)]
        string ArmorAndWeapons { get; }
    }
}