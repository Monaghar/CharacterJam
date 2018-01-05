using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public struct Stats
    {
        public int Stregnth { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public override string ToString()
        {

            return this.Stregnth.ToString() + ' ' +
                   this.Dexterity.ToString() + ' ' +
                   this.Constitution.ToString() + ' ' +
                   this.Intelligence.ToString() + ' ' +
                   this.Wisdom.ToString() + ' ' +
                   this.Charisma.ToString();
        }
    }

    public struct Skills
    {
        public int Acrobatics { get; set; }
        public int AnimalHandling { get; set; }
        public int Arcana { get; set; }
        public int Athletics { get; set; }
        public int Deception { get; set; }
        public int History { get; set; }
        public int Insight { get; set; }
        public int Intimidation { get; set; }
        public int Investigation { get; set; }
        public int Medicine { get; set; }
        public int Nature { get; set; }
        public int Perception { get; set; }
        public int Performance { get; set; }
        public int Persusion { get; set; }
        public int Religion { get; set; }
        public int SleightOfHand { get; set; }
        public int Stealth { get; set; }
        public int Survival { get; set; }
    }

    public struct Tools
    {
        public int ArtisansTools { get; set; }
        public int DisguiseKit { get; set; }
        public int ForgeryKit { get; set; }
        public int GamingSet { get; set; }
        public int HerbalismKit { get; set; }
        public int MusicalInstrument { get; set; }
        public int NavigatorsTools { get; set; }
        public int PoisonersKit { get; set; }
        public int ThievesTools { get; set; }
    }

    public class Lifestyles
    {
        public List<string> Lifestyle
        {
            get
            {
                return Lifestyle = new List<string>{
            "Wretched",
            "Squalid",
            "Poor",
            "Modest",
            "Cofortable",
            "Wealthy",
            "Aristocratic" };
            }
            set { }
        }
    }

    public static class Alignments
    {
        public static List<string> Alignment
        {
            get { return Alignment = new List<string>{
            "LawfulGood",
            "LawfulNeutral",
            "LawfulEvil",
            "NeutralGood",
            "TrueNeutral",
            "NeutralEvil",
            "ChoticGood",
            "ChaoticNeutral",
            "ChaoticEvil"}; }
            set { }
        }
    }

    //public static class 
}
