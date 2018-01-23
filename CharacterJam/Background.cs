using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public abstract class Background
    {
        public virtual List<string> Trait { get; set; }
        public virtual List<string> Ideal { get; set; }
        public virtual List<string> Bond { get; set; }
        public virtual List<string> Flaw { get; set; }
        public virtual Skills Skillz { get; set; }
        public virtual List<string> Language { get; set; }
    }
}