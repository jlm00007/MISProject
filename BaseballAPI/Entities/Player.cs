using System.ComponentModel.DataAnnotations;

namespace BaseballAPI.Entities
{
    public class Player
    {
        [Required]
        public int PID { get; set; }
      
        public string? Name { get; set; }
       
        public string? Number { get; set; }
        
        public string? Position { get; set; }
       
        public string TID { get; set; }
      
    }
}
