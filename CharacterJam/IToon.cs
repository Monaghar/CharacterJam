using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public interface IToon
    {
        string Name { get; }
        string Gender { get; }
        int Age { get; }
        List<string> Languages { get; }
        IRace Race { get; }
        Stats Stats { get; }
        Skills Skills { get; }
        Tools Tools { get; }
        string Lifestyle { get; }
        string Alignment { get; }
        //Background Background { get; }
    }
}