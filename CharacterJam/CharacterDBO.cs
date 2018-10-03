using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CharacterJam
{
    [Table("Characters")]
    public class CharacterDBO
    {
        public CharacterDBO(Character tempChar){
            Name = tempChar.Name;
            Gender = tempChar.Gender;
            Age = tempChar.Age;
            Languages = tempChar.Languages;
            Race = tempChar.Race.ToString();
            Class = tempChar.Class.ToString();
            Stats = tempChar.Stats.ToString(); 
            Skills = tempChar.Skills.ToString();
            Tools = tempChar.Tools.ToString();
            Lifestyle = tempChar.Lifestyle.ToString();
            Alignment = tempChar.Alignment.ToString();
            Background = tempChar.Background.ToString();
            Trait = tempChar.Trait.ToString();
            Ideal = tempChar.Ideal.ToString();
            Bond = tempChar.Bond.ToString();
            Flaw = tempChar.Flaw.ToString();
        }

        [Key]
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Languages { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public string Stats { get; set; }
        public string Skills { get; set; }
        public string Tools { get; set; }
        public string Lifestyle { get; set; }
        public string Alignment { get; set; }
        public string Background { get; set; }
        public string Trait { get; set; }
        public string Ideal { get; set; }
        public string Bond { get; set; }
        public string Flaw { get; set; }
    }
}