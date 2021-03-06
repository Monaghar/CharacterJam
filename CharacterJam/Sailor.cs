﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public class Sailor: Background
    {
        public override List<string> Trait
        {
            get { return new List<string> {
            "My friends know they can rely on me, no matter what.",
            "I work hard so that I can play hard when the work is done.",
            "I enjoy sailing into new ports and making new friends over a flagon of ale.",
            "I stretch the truth for the sake of a good story.",
            "To me, a tavern brawl is a nice way to get to know a new city.",
            "I never pass up a friendly wager.",
            "My language is as foul as an otyugh nest.",
            "I like a job well done, especially if I can convince someone else to do it."};
            }
        }

        public override List<string> Ideal
        {
            get { return new List<string>{
            "Respect. The thing that keeps a ship together is mutual respect between captain and crew. (Good)",
            "Fairness. We all do the work, so we all share in the rewards. (Lawful)",
            "Freedom. The sea is freedom—the freedom to go anywhere and do anything. (Chaotic)",
            "Mastery. I’m a predator, and the other ships on the sea are my prey. (Evil)",
            "People. I’m committed to my crewmates, not to ideals. (Neutral)",
            "Aspiration. Someday I’ll own my own ship and chart my own destiny. (Any)"};
            }
        }

        public override List<string> Bond
        {
            get { return new List<string> {
            "I’m loyal to my captain first, everything else second.",
            "The ship is most important—crewmates and captains come and go.",
            "I’ll always remember my first ship.",
            "In a harbor town, I have a paramour whose eyes nearly stole me from the sea.",
            "I was cheated out of my fair share of the profits, and I want to get my due.",
            "Ruthless pirates murdered my captain and crewmates, plundered our ship, and left me to die. Vengeance will be mine."};
            }
        }

        public override List<string> Flaw
        {
            get { return new List<string>{
            "I follow orders, even if I think they’re wrong.",
            "I’ll say anything to avoid having to do extra work.",
            "Once someone questions my courage, I never back down no matter how dangerous the situation.",
            "Once I start drinking, it’s hard for me to stop.",
            "I can’t help but pocket loose coins and other trinkets I come across.",
            "My pride will probably lead to my destruction." };
            }

        }

        public override Skills Skillz { get { return new Skills { Athletics = 2, Perception = 2 }; } } // 2 is prof bonus at lvl 1 
        public Tools Toolz { get { return new Tools { NavigatorsTools = 1 }; } }
        public override string ToString()
        {
            return "Sailor";
        }
    }
}
