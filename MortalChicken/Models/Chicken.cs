using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MortalChicken.Models
{
    public enum Color
    {
        White, Brown, Black, Red, Gray
    }
    
    public class Chicken
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Smarts { get; set; }
        public double Strength { get; set; }
        public double Speed { get; set; }
        public double Luck { get; set; }
        public Color Color { get; set; }
        [ForeignKey("FarmId")]
        public Farm Farm { get; set; }

    }
}
