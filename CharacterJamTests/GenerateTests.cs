using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterJam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam.Tests
{
    [TestClass()]
    public class GenerateTests
    {
        #region GivenVariables
        Random rnd = new Random();
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
        #endregion

        #region StatRolling
        [TestMethod()]
        public void RollStatsTestRange()
        {
            List<int> statArray = new List<int>();
            for (int i = 0; i < 300; i++)
            {
                statArray.Add(rnd.Next(3, 19));
            }
            //i think 15 is right 19-3 but it's probably an off by one error
            for (int x = 3; x < 19; x++)
            {
                Assert.IsTrue(statArray.Contains(x));
            }
        }
        #endregion

        #region RaceRolling
        [TestMethod()]
        public void RollRaceTestReturnsRace()
        {
            Character Jeff = new Character();
            Jeff.Race = Generate.RollRace(rnd);

            Assert.IsTrue(Generate.raceList.Contains(Jeff.Race));
        }
        #endregion

        #region ClassRolling
        [TestMethod()]
        public void RollClassTestReturnsClass()
        {
            Character Jeff = new Character();
            Jeff.Class = Generate.RollClass(rnd);
            Assert.IsTrue(Generate.classList.Contains(Jeff.Class));
        }
        #endregion

        #region BackgroundRolling
        [TestMethod()]
        public void RollBackgroundTestReturnsBG()
        {
            Character Jeff = new Character();
            Jeff.Background = Generate.RollBackground(rnd);
            Assert.IsTrue(Generate.BackgroundList.Contains(Jeff.Background));
        }
        #endregion

        #region LifestyleRolling
        [TestMethod()]
        public void RollLifestyleTestReturnsLifestyle()
        {
            Character Jeff = new Character();
            Jeff.Lifestyle = Generate.RollLifeStyle(rnd);
            switch(Jeff.Lifestyle)
            {
                case (Lifestyles)0:
                case (Lifestyles)1:
                case (Lifestyles)2:
                case (Lifestyles)3:
                case (Lifestyles)4:
                case (Lifestyles)5:
                case (Lifestyles)6:
                    Assert.IsTrue(true);
                    break;
            }
        }
        #endregion

        #region AlignmentRolling
        [TestMethod()]
        public void RollAlignmentTestReturnsAlignment()
        {
            Character Jeff = new Character();
            Jeff.Alignment = Generate.RollAlignment(rnd);
            switch (Jeff.Alignment)
            {
                case (Alignments)0:
                case (Alignments)1:
                case (Alignments)2:
                case (Alignments)3:
                case (Alignments)4:
                case (Alignments)5:
                case (Alignments)6:
                case (Alignments)7:
                case (Alignments)8:
                    Assert.IsTrue(true);
                    break;
            }
        }
        #endregion

        //#region NameRolling
        //[TestMethod()]
        //public void RollNameTestReturnsName()
        //{
        //    Character Jeff = new Character();
        //    Jeff.Name = Generate.RollName();
        //    Assert.IsTrue();
        //}
        //#endregion

        #region AgeRolling
        [TestMethod()]
        public void RollAgeTestReturnsAge()
        {
            Character Jeff = new Character();
            Jeff.Race = Generate.RollRace(rnd);
            Jeff.Age = Generate.RollAge(rnd, Jeff.Race);
            List<int> statArray = new List<int>();
            for (int i = 0; i < 30000; i++)
            {
                statArray.Add(rnd.Next(Jeff.Race.AgeRange));
            }
            Assert.IsTrue(statArray.Contains(Jeff.Age));
        }
        #endregion

        //#region LanguageRolling
        //[TestMethod()]
        //public void RollLanguageTestReturnsLanguages()
        //{
        //    Character Jeff = new Character();
        //    Jeff.Languages = Generate.Language();
        //    Assert.IsTrue();
        //}
        //#endregion
    }
}