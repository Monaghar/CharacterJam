using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CharacterJam
{
    [Table("studentdetails")]
    public class CharacterDBO
    {
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