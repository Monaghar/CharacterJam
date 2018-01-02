using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Criminal : Background
    {
        public List<string> Trait
        {
            get { return Trait = new List<string> {
            "I always have a plan for when things go wrong.",
            "I am always calm, no matter what the situation. I never raise my voice or let me emotions control me.",
            "The First thing i do in a new place is note the locations of everything valuable, or where such things could be hidden.",
            "I would rather make a new friend than a new enemy.",
            "I am incredibly slow to trust. Those who seem the fairest often have the most to hide.",
            "I don't pay attention to the risks in a situation. Never tell me the odds.",
            "The best way to get me to do something is to tell me i can't do it.",
            "I blow up at the slightest insult."};
            }
            private set{}
        }

        public List<string> Ideal
        {
            get { return Ideal = new List<string>{
            "Honor. I don’t steal from others in the trade. (Lawful)",
            "Freedom. Chains are meant to be broken, as are those who would forge them. (Chaotic)",
            "Charity. I steal from the wealthy so that I can help people in need. (Good)",
            "Greed. I will do whatever it takes to become wealthy. (Evil)",
            "People. I’m loyal to my friends, not to any ideals, and everyone else can take a trip down the Styx for all I care. (Neutral)",
            "Redemption. There’s a spark of good in everyone. (Good)"};
            }
            private set{}
        }

        public List<string> Bond
        {
            get { return Bond = new List<string> {
            "I’m trying to pay off an old debt I owe to a generous benefactor.",
            "My ill-gotten gains go to support my family.",
            "Something important was taken from me, and I aim to steal it back.",
            "I will become the greatest thief that ever lived.",
            "I’m guilty of a terrible crime. I hope I can redeem myself for it.",
            "Someone I loved died because of a mistake I made. That will never happen again."};
            }
            private set{}
        }

        public List<string> Flaw
        {
            get { return Flaw = new List<string>{
            "When I see something valuable, I can’t think about anything but how to steal it.",
            "When faced with a choice between money and my friends, I usually choose the money.",
            "If there’s a plan, I’ll forget it. If I don’t forget it, I’ll ignore it.",
            "I have a “tell” that reveals when I'm lying.",
            "I turn tail and run when things look bad.",
            "An innocent person is in prison for a crime that I committed. I’m okay with that." };
            }
            private set{}
        }

        public Skills Skillz { get { return Skillz = new Skills { Deception = 2, Stealth = 2 };  ; } private set {} } // 2 is prof bonus at lvl 1 
        public  Tools Toolz { get { return Toolz = new Tools { GamingSet = 1, ThievesTools = 1 }; ; } private set {} }
    }
}
