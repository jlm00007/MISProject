using System.ComponentModel.DataAnnotations;


namespace BaseballSiteAPI.Entities
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
