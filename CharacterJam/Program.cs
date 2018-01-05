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
            Jeff.Trait = Jeff.Background.Trait[rnd.Next(Jeff.Background.Trait.Count)];
            Jeff.Ideal = Jeff.Background.Ideal[rnd.Next(Jeff.Background.Ideal.Count)];
            Jeff.Bond = Jeff.Background.Bond[rnd.Next(Jeff.Background.Bond.Count)];
            Jeff.Flaw = Jeff.Background.Flaw[rnd.Next(Jeff.Background.Flaw.Count)];
            Console.WriteLine("Trait : " + Jeff.Trait);
            Console.WriteLine("Ideal : " + Jeff.Ideal);
            Console.WriteLine("Bond : " + Jeff.Bond);
            Console.WriteLine("Flaw : " + Jeff.Flaw);
            Jeff.Lifestyle = Generate.RollLifeStyle(rnd);
            Jeff.Alignment = Generate.RollAlignment(rnd);
            Console.WriteLine("Alignment : " + Jeff.Alignment);
            Console.WriteLine("Lifestyle : " + Jeff.Lifestyle);
            Jeff.Name = Generate.RollName(rnd);
            Console.WriteLine("Name: " + Jeff.Name);
            //Acolyte ass = new Acolyte();
            //var ACOL = ass.Trait[rnd.Next(ass.Trait.Count)];
            //Console.Write(ACOL);
            Console.Read();
        }
    }
}