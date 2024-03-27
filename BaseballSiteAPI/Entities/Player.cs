using System.ComponentModel.DataAnnotations;

namespace BaseballSiteAPI.Entities
{
    public class Player
    {
        [Key]
        public short PID { get; set; }
        public required string Name { get; set; }
        public short? Number { get; set; }
        public required string Position { get; set; }
        public short? TID { get; set; }
    }
}
