using System.ComponentModel.DataAnnotations;

namespace BaseballAPI.Entities
{
    public class Stat
    {
        [Required]
        public int PID { get; set; }

        public int? Hits { get; set; }

        public int? Strikeouts { get; set; }

        public int? Homeruns { get; set; }


    }
}
