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
        [TestMethod()]
        public void RollStatsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RollRaceTest()
        {
            Random rnd = new Random();
            Character Jeff = new Character();
            Jeff.Race = Generate.RollRace(rnd);
            Assert.IsNotNull(Jeff.Race);
            
        }
    }
}