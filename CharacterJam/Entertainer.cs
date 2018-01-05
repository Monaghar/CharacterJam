using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Entertainer : Background
    {
        public override List<string> Trait
        {
            get {
                return Trait = new List<string> {
            "I know a story relevant to almost every situation.",
            "Whenever I come to a new place, I collect local rumors and spread gossip.",
            "I’m a hopeless romantic, always searching for that “special someone.” ",
            "Nobody stays angry at me or around me for long, since I can defuse any amount of tension.",
            "I love a good insult, even one directed at me.",
            "I get bitter if I’m not the center of attention.",
            "I’ll settle for nothing less than perfection.",
            "I change my mood or my mind as quickly as I change key in a song."};
            }
            set{}
        }

        public override List<string> Ideal
        {
            get { return Ideal = new List<string>{
            "Beauty. When I perform, I make the world better than it was. (Good)",
            "Tradition. The stories, legends, and songs o f the past must never be forgotten, for they teach us who we are. (Lawful)",
            "Creativity. The world is in need of new ideas and bold action. (Chaotic)",
            "Greed. I’m only in it for the money and fame. (Evil)",
            "People. I like seeing the smiles on people’s faces when I perform. That’s all that matters. (Neutral)",
            "Honesty. Art should reflect the soul; it should come from within and reveal who we really are. (Any)"};
            }
            set{}
        }

        public override List<string> Bond
        {
            get { return Bond = new List<string> {
            "My instrument is my most treasured possession, and it reminds me of someone I love.",
            "Someone stole my precious instrument, and someday I’ll get it back.",
            "I want to be famous, whatever it takes.",
            "I idolize a hero of the old tales and measure my deeds against that person’s.",
            "I will do anything to prove myself superior to my hated rival.",
            "I would do anything for the other members of my old troupe."};
            }
            set{}
        }

        public override List<string> Flaw
        {
            get { return Flaw = new List<string>{
            "I’ll do anything to win fame and renown.",
            "I’m a sucker for a pretty face.",
            "A scandal prevents me from ever going home again. That kind of trouble seems to follow me around.",
            "I once satirized a noble who still wants my head. It was a mistake that I will likely repeat.",
            "I have trouble keeping my true feelings hidden. My sharp tongue lands me in trouble.",
            "Despite my best efforts, I am unreliable to my friends." };
            }
            set{}
        }

        public override Skills Skillz { get { return Skillz = new Skills { Acrobatics = 2, Performance = 2 }; }  set {}} // 2 is prof bonus at lvl 1 
        public Tools Toolz { get { return Toolz = new Tools { DisguiseKit = 1, MusicalInstrument = 1 }; }  set {}}
        public override string ToString()
        {
            return "Background: Entertainer";
        }
    }
}
