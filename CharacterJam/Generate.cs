using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public static class Generate
    {
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
            var Delf = new DarkElf();
            var DBorn = new Dragonborn();
            var FGnome = new ForestGnome();
            var Halfelf = new HalfElf();
            var Horc = new HalfOrc();
            var Helf = new HighElf();
            var Hdwarf = new HillDwarf();
            var LHalfling = new LightfootHalfling();
            var Mdwarf = new MountainDwarf();
            var Rgnome = new RockGnome();
            var Shalfling = new StoutHalfling();
            var Tief = new Tiefling();
            var Welf = new WoodElf();
            var raceList = new List<IRace>()
            {
                Delf, DBorn, FGnome, Halfelf, Horc, Helf, Hdwarf, LHalfling, Mdwarf, Rgnome, Shalfling, Tief, Welf
            };
            int r = rnd.Next(raceList.Count);
            return raceList[r];
        }

        public static IClass RollClass(Random rnd)
        {
            var Barb = new Barbarian();
            var Bard = new Bard();
            var Cleric = new Cleric();
            var Druid = new Druid();
            var Fight = new Fighter();
            var Monk = new Monk();
            var Paladin = new Paladin();
            var Ranger = new Ranger();
            var Rogue = new Rogue();
            var Sorc = new Sorcerer();
            var Warlok = new Warlock();
            var Wiz = new Wizard();
            var classList = new List<IClass>()
            {
                Barb, Bard, Cleric, Druid, Fight, Monk, Paladin, Ranger, Rogue, Sorc, Warlok, Wiz
            };
            int r = rnd.Next(classList.Count);
            return classList[r];
        }

        public static Background RollBackground(Random rnd)
        {
            var acolyte = new Acolyte();
            var charlatan = new Charlatan();
            var criminal = new Criminal();
            var entertainer = new Entertainer();
            var folkHero = new FolkHero();
            var guildArtisan = new GuildArtisan();
            var hermit = new Hermit();
            var noble = new Noble();
            var outlander = new Outlander();
            var sage = new Sage();
            var sailor = new Sailor();
            var soldier = new Soldier();
            var urchin = new Urchin();
            var BackgroundList = new List<Background>()
            {
                acolyte, charlatan, criminal, entertainer, folkHero, guildArtisan, hermit, noble, outlander, sage, sailor, soldier, urchin
            };
            int r = rnd.Next(BackgroundList.Count);
            return BackgroundList[r];
        }

        public static string RollLifeStyle(Random rnd)
        {
            Lifestyles life = new Lifestyles();
            return life.Lifestyle[rnd.Next(life.Lifestyle.Count)];
        }

        public static string RollAlignment(Random rnd)
        {
            return Alignments.Alignment[rnd.Next(Alignments.Alignment.Count)];
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
    }
}
