using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Charlatan : Background
    {
        public List<string> Scam
        {
            get { return Scam = new List<string> {
            "I cheat at games.",
            "I shave coins or forge documents.",
            "I insinuate myself into people’s lives to prey on their weakness and secure their fortunes.",
            "I put on new identities like clothes.",
            "I run sleight-of-hand cons on street corners.",
            "I convince people that worthless junk is worth their hard-earned money."};
            }
            set{}
        }

        public override List<string> Trait
        {
            get { return Trait = new List<string> {
            "I fall in and out of love easily, and am always pursuing someone.",
            "I have a joke for every occasion, especially occasions where humor is inappropriate.",
            "Flattery is my preferred trick for getting what I want.",
            "I’m a born gambler who can't resist taking a risk for a potential payoff.",
            "I lie about almost everything, even when there’s no good reason to.",
            "Sarcasm and insults are my weapons of choice.",
            "I keep multiple holy symbols on me and invoke whatever deity might come in useful at any given moment.",
            "I pocket anything I see that might have some value."};
            }
            set{}
        }

        public override List<string> Ideal
        {
            get { return Ideal = new List<string>{
            "Independence. I am a free spirit— no one tells me what to do. (Chaotic)",
            "Fairness. I never target people who can’t afford to lose a few coins. (Lawful)",
            "Charity. I distribute the money I acquire to the people who really need it. (Good)",
            "Creativity. I never run the same con twice. (Chaotic)",
            "Friendship. Material goods come and go. Bonds of friendship last forever. (Good)",
            "Aspiration. I’m determined to make something of myself. (Any)"};
            }
            set{}
        }

        public override List<string> Bond
        {
            get { return Bond = new List<string> {
            "I fleeced the wrong person and must work to ensure that this individual never crosses paths with me or those I care about.",
            "I owe everything to my mentor—a horrible person who’s probably rotting in jail somewhere.",
            "Somewhere out there, I have a child who doesn’t know me. I’m making the world better for him or her.",
            "I come from a noble family, and one day I’ll reclaim my lands and title from those who stole them from me.",
            "A powerful person killed someone I love. Some day soon, I’ll have my revenge.",
            "I swindled and ruined a person who didn’t deserve it. I seek to atone for my misdeeds but might never be able to forgive myself."};
            }
            set{}
        }

        public override List<string> Flaw
        {
            get { return Flaw = new List<string>{
            "I can’t resist a pretty face.",
            "I'm always in debt. I spend my ill-gotten gains on decadent luxuries faster than I bring them in.",
            "I’m convinced that no one could ever fool me the way I fool others.",
            "I’m too greedy for my own good. I can’t resist taking a risk if there’s money involved.",
            "I can’t resist swindling people who are more powerful than me.",
            "I hate to admit it and will hate myself for it, but I'll run and preserve my own hide if the going gets tough." };
            }
            set{}
        }

        public override Skills Skillz { get { return Skillz = new Skills { Deception = 2, SleightOfHand = 2 }; } set {} } // 2 is prof bonus at lvl 1 
        public Tools Toolz { get { return Toolz = new Tools { DisguiseKit = 1, ForgeryKit = 1 }; } set {} }
        public override string ToString()
        {
            return "Background: Charlatan";
        }
    }
}
