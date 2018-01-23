using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public static class Generate
    {
        static DarkElf Delf = new DarkElf();
        static Dragonborn DBorn = new Dragonborn();
        static ForestGnome FGnome = new ForestGnome();
        static HalfElf Halfelf = new HalfElf();
        static HalfOrc Horc = new HalfOrc();
        static HighElf Helf = new HighElf();
        static HillDwarf Hdwarf = new HillDwarf();
        static LightfootHalfling LHalfling = new LightfootHalfling();
        static MountainDwarf Mdwarf = new MountainDwarf();
        static RockGnome Rgnome = new RockGnome();
        static StoutHalfling Shalfling = new StoutHalfling();
        static Tiefling Tief = new Tiefling();
        static WoodElf Welf = new WoodElf();
        static List<IRace> raceList = new List<IRace>()
            {
                Delf, DBorn, FGnome, Halfelf, Horc, Helf, Hdwarf, LHalfling, Mdwarf, Rgnome, Shalfling, Tief, Welf
            };
         
        static Barbarian Barb = new Barbarian();
        static Bard Bard = new Bard();
        static Cleric Cleric = new Cleric();
        static Druid Druid = new Druid();
        static Fighter Fight = new Fighter();
        static Monk Monk = new Monk();
        static Paladin Paladin = new Paladin();
        static Ranger Ranger = new Ranger();
        static Rogue Rogue = new Rogue();
        static Sorcerer Sorc = new Sorcerer();
        static Warlock Warlok = new Warlock();
        static Wizard Wiz = new Wizard();
        static List<IClass> classList = new List<IClass>()
            {
                Barb, Bard, Cleric, Druid, Fight, Monk, Paladin, Ranger, Rogue, Sorc, Warlok, Wiz
            };

        static Acolyte acolyte = new Acolyte();
        static Charlatan charlatan = new Charlatan();
        static Criminal criminal = new Criminal();
        static Entertainer entertainer = new Entertainer();
        static FolkHero folkHero = new FolkHero();
        static GuildArtisan guildArtisan = new GuildArtisan();
        static Hermit hermit = new Hermit();
        static Noble noble = new Noble();
        static Outlander outlander = new Outlander();
        static Sage sage = new Sage();
        static Sailor sailor = new Sailor();
        static Soldier soldier = new Soldier();
        static Urchin urchin = new Urchin();
        static List<Background> BackgroundList = new List<Background>()
            {
                acolyte, charlatan, criminal, entertainer, folkHero, guildArtisan, hermit, noble, outlander, sage, sailor, soldier, urchin
            };

        public static List<int> RollStats(Random rnd)
        {
            List<int> statArray = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                statArray.Add(rnd.Next(3, 18));
            }
            return statArray;
        }

        public static IRace RollRace(Random rnd)
        {
            int r = rnd.Next(raceList.Count);
            return raceList[r];
        }

        public static IClass RollClass(Random rnd)
        {
            int r = rnd.Next(classList.Count);
            return classList[r];
        }

        public static Background RollBackground(Random rnd)
        {
           
            int r = rnd.Next(BackgroundList.Count);
            return BackgroundList[r];
        }

        public static Lifestyles RollLifeStyle(Random rnd)
        {
            Array values = Enum.GetValues(typeof(Lifestyles));
            Lifestyles thing = (Lifestyles)values.GetValue(rnd.Next(values.Length));
            return thing;
        }

        public static Alignments RollAlignment(Random rnd)
        {
            Array values = Enum.GetValues(typeof(Alignments));
            Alignments thing = (Alignments)values.GetValue(rnd.Next(values.Length));
            return thing;
        }

        public static string RollName(Random rnd)
        {
            string firstName;
            int gender = rnd.Next(0, 1);
            if (gender == 0)
            {
                firstName = Names.FemaleNames[rnd.Next(Names.FemaleNames.Count)];
                return firstName + " " + Names.LastNames[rnd.Next(Names.LastNames.Count)];
            }
            if (gender == 1)
            {
                firstName = Names.MaleNames[rnd.Next(Names.MaleNames.Count)];
                return firstName + " " + Names.LastNames[rnd.Next(Names.LastNames.Count)];
            }

            return "Generate.RollName failed to generate a name";
        }

        //public static string RollLanguage(Random rnd)
        //{
        //    return background + race language list &random if needed
        //}
    }
}
