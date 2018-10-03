using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data.Entity;

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

            Jeff.CharacterId = 1;
            Jeff.Race = Generate.RollRace(rnd);
            Console.WriteLine(Jeff.Race.ToString());
            Jeff.Class = Generate.RollClass(rnd);
            Console.WriteLine(Jeff.Class.ToString());
            stat.Stregnth = statList[0] + Jeff.Race.StrBonus;
            stat.Dexterity = statList[1] + Jeff.Race.DexBonus;
            stat.Constitution = statList[2] + Jeff.Race.ConBonus;
            stat.Intelligence = statList[3] + Jeff.Race.IntBonus;
            stat.Wisdom = statList[4] + Jeff.Race.WisBonus;
            stat.Charisma = statList[5] + Jeff.Race.ChaBonus;
            Jeff.Stats = stat;
            Console.WriteLine(Jeff.Stats.ToString());
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
            Jeff.Age = Generate.RollAge(rnd, Jeff.Race);
            Console.WriteLine("My Age is: {0}", Jeff.Age);
            Jeff.Languages = Generate.RollLanguage(rnd, Jeff);
            Console.WriteLine("I speak: {0}", Jeff.Languages);

            //string fileName = "Characters!!.txt";
            //File.WriteAllText(fileName, "trait: " + Jeff.Trait);
            //string text = File.ReadAllText("side quests.txt");
            string json = JsonConvert.SerializeObject(Jeff, Formatting.Indented);
            //using (StreamWriter filez = new StreamWriter("C://Users//ryan//Desktop//gamez//DD//character.txt", true))
            //{
            //    filez.WriteLine(json);
            //}
            File.WriteAllText("CharacterJson.txt", json);

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion\< dbContext, Configuration > ());
            CharacterDBO DboJeff = new CharacterDBO(Jeff);
            using (var db = new Model1())
            {
                db.Characters.Add(DboJeff);
                db.SaveChanges(); 

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
} 