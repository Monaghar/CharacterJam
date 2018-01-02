using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public abstract class Background
    {
        public List<string> Trait { get; }
        public List<string> Ideal { get; }
        public List<string> Bond { get; }
        public List<string> Flaw { get; }
        public Skills Skillz { get; }
    }
}
