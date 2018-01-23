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
        public enum Languages { };
        public IRace Race { get; set; }
        public IClass Class { get; set; }
        public Stats Stats { get; set; }
        public Skills Skills { get; set; }
        public Tools Tools { get; set; }
        public Lifestyles Lifestyle { get; set; }
        public Alignments Alignment { get; set; }
        public Background Background { get; set; }
        public string Trait { get; set; }
        public string Ideal { get; set; }
        public string Bond { get; set; }
        public string Flaw { get; set; }
    }
}