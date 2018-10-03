using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Outlander : Background
    {
        public List<string> Origin
        {
            get {
                return new List<string> {
            "Forester",
            "Trapper",
            "Homesteader",
            "Guide",
            "Exile or outcast",
            "Bounty hunter",
            "Pilgrim",
            "Hunter-gatherer",
            "Tribal marauder",
            "Tribal nomad"}; }
        }

        public override List<string> Trait
        {
            get {
                return new List<string> {
            "I’m driven by a wanderlust that led me away from home.",
            "I watch over my friends as if they were a litter of newborn pups.",
            "I once ran twenty-five miles without stopping to warn to my clan of an approaching orc horde. I’d do it again if I had to.",
            "I have a lesson for every situation, drawn from observing nature.",
            "I place no stock in wealthy or well-mannered folk. Money and manners won’t save you from a hungry owlbear.",
            "I’m always picking things up, absently fiddling with them, and sometimes accidentally breaking them.",
            "I feel far more comfortable around animals than people.",
            "I was, in fact, raised by wolves."};
            }
        }

        public override List<string> Ideal
        {
            get {
                return new List<string>{
            "Change. Life is like the seasons, in constant change, and we must change with it. (Chaotic)",
            "Greater Good. It is each person’s responsibility to make the most happiness for the whole tribe. (Good)",
            "Honor. If I dishonor myself, I dishonor my whole clan. (Lawful)",
            "Might. The strongest are meant to rule. (Evil)",
            "Nature. The natural world is more important than all the constructs of civilization. (Neutral)",
            "Glory. I must earn glory in battle, for myself and my clan. (Any)"};
            }
        }

        public override List<string> Bond
        {
            get {
                return new List<string> {
            "My family, clan, or tribe is the most important thing in my life, even when they are far from me.",
            "An injury to the unspoiled wilderness of my home is an injury to me.",
            "I will bring terrible wrath down on the evildoers who destroyed my homeland.",
            "I am the last of my tribe, and it is up to me to ensure their names enter legend.",
            "I suffer awful visions of a coming disaster and will do anything to prevent it.",
            "It is my duty to provide children to sustain my tribe."};
            }
        }

        public override List<string> Flaw
        {
            get { return new List<string>{
            "I am too enamored of ale, wine, and other intoxicants.",
            "There’s no room for caution in a life lived to the fullest.",
            "I remember every insult I’ve received and nurse a silent resentment toward anyone who’s ever wronged me.",
            "I am slow to trust members of other races, tribes, and societies.",
            "Violence is my answer to almost any challenge.",
            "Don’t expect me to save those who can’t save themselves. It is nature’s way that the strong thrive and the weak perish." };
            }
        }

        public override Skills Skillz { get { return new Skills { Athletics = 2, Survival = 2 }; } } // 2 is prof bonus at lvl 1 
        public Tools Toolz { get { return new Tools { MusicalInstrument = 1 }; } }
        public List<string> Language { get { return new List<string> { "One Languages of your Choice" }; } } //make random?
        public override string ToString()
        {
            return "Outlander";
        }
    }
}
