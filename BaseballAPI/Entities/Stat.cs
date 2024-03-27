using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseballAPI.Entities
{
    public class Stat
    {
        [Key]
        [Required]
        public short SID { get; set; }
        
        public short PID { get; set; }
        public short? Hits { get; set; }

        public short? Strikeouts { get; set; }

        public short? Homeruns { get; set; }


    }
}
