using System.ComponentModel.DataAnnotations;

namespace BaseballAPI.Entities
{
    public class Player
    {
        [Key]
        [Required]
        public short PID { get; set; }
      
        public string? Name { get; set; }
       
        public short? Number { get; set; }
        
        public required string Position { get; set; }
       
        public short TID { get; set; }
      
    }
}
