using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Character : IToon
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
        public IRace Race { get; set; }
        public IClass Class { get; set; }
        public Stats Stats { get; set; }
        public Skills Skills { get; set; }
        public Tools Tools { get; set; }
        public Lifestyle Lifestyle { get; set; }
        public Alignment Alignment { get; set; }
        public Background Background { get; set; }
    }
}