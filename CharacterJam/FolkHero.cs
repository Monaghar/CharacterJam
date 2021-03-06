﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class FolkHero : Background
    {
        public  List<string> DefiningEvent
        {
            get {
                return new List<string> {
            "I stood up to a tyrant’s agents.",
            "I saved people during a natural disaster.",
            "I stood alone against a terrible monster.",
            "I stole from a corrupt merchant to help the poor.",
            "I led a militia to fight off an invading army.",
            "I broke into a tyrant’s castle and stole weapons to arm the people.",
            "I trained the peasantry to use farm implements as weapons against a tyrant’s soldiers.",
            "A lord rescinded an unpopular decree after I led a symbolic act of protect against it.",
            "A celestial, fey, or similar creature gave me a blessing or revealed my secret origin.",
            "Recruited into a lord’s army, I rose to leadership and was commended for my heroism."};
            }
        }

        public override List<string> Trait
        {
            get { return new List<string> {
            "I judge people by their actions, not their words.",
            "If someone is in trouble, I’m always ready to lend help.",
            "When I set my mind to something, I follow through no matter what gets in my way.",
            "I have a strong sense of fair play and always try to find the most equitable solution to arguments.",
            "I’m confident in my own abilities and do what I can to instill confidence in others.",
            "Thinking is for other people. I prefer action.",
            "I misuse long words in an attempt to sound smarter.",
            "I get bored easily. When am I going to get on with my destiny?"};
            }
        }

        public override List<string> Ideal
        {
            get {
                return new List<string>{
            "Respect. People deserve to be treated with dignity and respect. (Good)",
            "Fairness. No one should get preferential treatment before the law, and no one is above the law. (Lawful)",
            "Freedom. Tyrants must not be allowed to oppress the people. (Chaotic)",
            "Might. If I become strong, I can take what I want— what I deserve. (Evil)",
            "Sincerity. There’s no good in pretending to be something I’m not. (Neutral)",
            "Destiny. Nothing and no one can steer me away from my higher calling. (Any)"};
            }
        }

        public override List<string> Bond
        {
            get {
                return new List<string> {
            "I have a family, but I have no idea where they are. One day, I hope to see them again.",
            "I worked the land, I love the land, and I will protect the land.",
            "A proud noble once gave me a horrible beating, and I will take my revenge on any bully I encounter.",
            "My tools are symbols of my past life, and I carry them so that I will never forget my roots.",
            "I protect those who cannot protect themselves.",
            "I wish my childhood sweetheart had come with me to pursue my destiny."};
            }
        }

        public override List<string> Flaw
        {
            get { return new List<string>{
            "The tyrant who rules my land will stop at nothing to see me killed.",
            "I’m convinced of the significance of my destiny, and blind to my shortcomings and the risk of failure.",
            "The people who knew me when I was young know my shameful secret, so I can never go home again.",
            "I have a weakness for the vices of the city, especially hard drink.",
            "Secretly, I believe that things would be better if I were a tyrant lording over the land.",
            "I have trouble trusting in my allies." };
            }
        }

        public override Skills Skillz { get { return new Skills { AnimalHandling = 2, Survival = 2 }; } }  // 2 is prof bonus at lvl 1 
        public Tools Toolz { get { return new Tools { ArtisansTools = 1, NavigatorsTools = 1 }; } }
        public override string ToString()
        {
            return "Folk Hero";
        }
    }
}
