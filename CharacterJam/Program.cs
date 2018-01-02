using System;
using RandomNameGenerator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Character Jeff = new Character();
            Stats stat = new Stats();
            var statList = Generate.RollStats(rnd);
            stat.Stregnth = statList[0];
            stat.Dexterity = statList[1];
            stat.Constitution = statList[2];
            stat.Intelligence = statList[3];
            stat.Wisdom = statList[4];
            stat.Charisma = statList[5];
            Jeff.Stats = stat;
            Console.WriteLine(Jeff.Stats.ToString());
            Human Huuman = new Human();
            Jeff.Race = Generate.RollRace(rnd);
            Console.WriteLine(Jeff.Race.ToString());
            Jeff.Class = Generate.RollClass(rnd);
            Console.WriteLine(Jeff.Class.ToString());
            Jeff.Background = Generate.RollBackground(rnd);
            string ACOL = Generate.RollTrait(rnd);
            Console.Write(ACOL);
            Console.Read();
        }
    }
}