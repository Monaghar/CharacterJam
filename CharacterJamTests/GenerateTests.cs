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
        #region StatRolling
        [TestMethod()]
        public void RollStatsTestNotNull()
        {
            List<int> statArray = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                statArray.Add(rnd.Next(3, 19));
            }
            Assert.IsNotNull(statArray);
        }

        [TestMethod()]
        public void RollStatsTestRange()
        {
            List<int> statArray = new List<int>();
            for (int i = 0; i < 200; i++) ;
            {
                statArray.Add(rnd.Next(3, 19));
            }
            //i think 15 is right 18-3 but it's probably an off by one error
            for (int x = 3; x < 15; x++)
            {
                Assert.statArray.Contains(x);
            }
        }
        #endregion

        [TestMethod()]
        public void RollRaceTest()
        {
            Random rnd = new Random();
            Character Jeff = new Character();
            Jeff.Race = Generate.RollRace(rnd);
            Assert.IsNotNull(Jeff.Race);
        }

        [TestMethod()]
        {
            
        }
    }
}