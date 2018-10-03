using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Hermit : Background
    {
        public List<string> LifeOfSeclusion
        {
            get { return new List<string> {
            "I was searching for spiritual enlightenment.",
            "I was partaking of communal living in accordance with the dictates of a religious order.",
            "I was exiled for a crime I didn’t commit.",
            "I retreated from society after a life-altering event.",
            "I needed a quiet place to work on my art, literature, music, or manifesto.",
            "I needed to commune with nature, far from civilization.",
            "I was the caretaker of an ancient ruin or relic.",
            "I was a pilgrim in search of a person, place, or relic of spiritual significance."};
            }
        }

        public override List<string> Trait
        {
            get { return new List<string> {"I’ve been isolated for so long that I rarely speak, preferring gestures and the occasional grunt.",
            "I am utterly serene, even in the face of disaster.",
            "The leader of my community had something wise to say on every topic, and I am eager to share that wisdom.",
            "I feel tremendous empathy for all who suffer.",
            "I’m oblivious to etiquette and social expectations.",
            "I connect everything that happens to me to a grand, cosmic plan.",
            "I often get lost in my own thoughts and contemplation, becoming oblivious to my surroundings.",
            "I am working on a grand philosophical theory and love sharing my ideas."};
        }
        }

        public override List<string> Ideal
        {
            get { return new List<string>{
            "Greater Good. My gifts are meant to be shared with all, not used for my own benefit. (Good)",
            "Logic. Emotions must not cloud our sense of what is right and true, or our logical thinking. (Lawful)",
            "Free Thinking. Inquiry and curiosity are the pillars of progress. (Chaotic)",
            "Power. Solitude and contemplation are paths toward mystical or magical power. (Evil)",
            "Live and Let Live. Meddling in the affairs o f others only causes trouble. (Neutral)",
            "Self-Knowledge. If you know yourself, there’s nothing left to know. (Any)"};
            }
        }

        public override List<string> Bond
        {
            get {
                return new List<string> {
            "Nothing is more important than the other members of my hermitage, order, or association.",
            "I entered seclusion to hide from the ones who might still be hunting me. I must someday confront them.",
            "I’m still seeking the enlightenment I pursued in my seclusion, and it still eludes me.",
            "I entered seclusion because I loved someone I could not have.",
            "Should my discovery come to light, it could bring ruin to the world.",
            "My isolation gave me great insight into a great evil that only I can destroy."};
            }
        }

        public override List<string> Flaw
        {
            get { return new List<string>{
            "Now that I've returned to the world, I enjoy its delights a little too much.",
            "I harbor dark, bloodthirsty thoughts that my isolation and meditation failed to quell.",
            "I am dogmatic in my thoughts and philosophy.",
            "I let my need to win arguments overshadow friendships and harmony.",
            "I’d risk too much to uncover a lost bit of knowledge.",
            "I like keeping secrets and won’t share them with anyone." };
            }
        }

        public override Skills Skillz { get { return new Skills { Medicine = 2, Religion = 2 }; } } // 2 is prof bonus at lvl 1 
        public Tools Toolz { get { return new Tools { HerbalismKit = 1 }; } }
        public override string ToString()
        {
            return "Hermit";
        }
    }
}
