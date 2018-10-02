using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace CharacterJam
{
    class Program
    {
        static void Main(string[] args) 
        {    
            Random rnd = new Random();
            CharacterDBO Jeff = new CharacterDBO();
            Stats stat = new Stats();
            var statList = Generate.RollStats(rnd);

            //Human Huuman = new Human();
            Jeff.CharacterId = 1;
            //Jeff.Race = Generate.RollRace(rnd);
            Jeff.Race = "Orc";
            Console.WriteLine(Jeff.Race.ToString());
            //Jeff.Class = Generate.RollClass(rnd);
            Jeff.Class = "Fighter";
            Console.WriteLine(Jeff.Class.ToString());
            stat.Stregnth = statList[0];// + Jeff.Race.StrBonus;
            stat.Dexterity = statList[1];// + Jeff.Race.DexBonus;
            stat.Constitution = statList[2];// + Jeff.Race.ConBonus;
            stat.Intelligence = statList[3];// + Jeff.Race.IntBonus;
            stat.Wisdom = statList[4];// + Jeff.Race.WisBonus;
            stat.Charisma = statList[5];// + Jeff.Race.ChaBonus;
            Jeff.Stats = "1,2,3,4,5,6";//stat;
            Console.WriteLine(Jeff.Stats.ToString());
            Jeff.Background = "from tatooine";//Generate.RollBackground(rnd);
            Jeff.Trait = "real trait";//Jeff.Background.Trait[rnd.Next(Jeff.Background.Trait.Count)];
            Jeff.Ideal = "real ideal";//Jeff.Background.Ideal[rnd.Next(Jeff.Background.Ideal.Count)];
            Jeff.Bond = "real bond";//Jeff.Background.Bond[rnd.Next(Jeff.Background.Bond.Count)];
            Jeff.Flaw = "real flaw";//Jeff.Background.Flaw[rnd.Next(Jeff.Background.Flaw.Count)];
            Console.WriteLine("Trait : " + Jeff.Trait);
            Console.WriteLine("Ideal : " + Jeff.Ideal);
            Console.WriteLine("Bond : " + Jeff.Bond);
            Console.WriteLine("Flaw : " + Jeff.Flaw);
            Jeff.Lifestyle = "great";//Generate.RollLifeStyle(rnd);
            Jeff.Alignment = "okay ish";//Generate.RollAlignment(rnd);
            Console.WriteLine("Alignment : " + Jeff.Alignment);
            Console.WriteLine("Lifestyle : " + Jeff.Lifestyle);
            Jeff.Name = Generate.RollName(rnd);
            Console.WriteLine("Name: " + Jeff.Name);
            Jeff.Age = 77;//Generate.RollAge(rnd, Jeff.Race);
            Console.WriteLine("My Age is: {0}", Jeff.Age);
            Jeff.Languages = "english"; //Generate.RollLanguage(rnd, Jeff);
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

            using (var db = new Model1())
            {
                // Create and save a new Blog
                Console.Write("Enter a text for no reasn: ");
                var name = Console.ReadLine();

                var chara = Jeff;
                db.Characters.Add(chara);
                db.SaveChanges();

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
} 