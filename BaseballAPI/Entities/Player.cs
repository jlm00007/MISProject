using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseballAPI.Entities
{
    public class Player
    {
        [Required]
        public int PID { get; set; }
      
        public string Name { get; set; }
       
        public string Number { get; set; }
        
        public string Position { get; set; }
       
        public string TID { get; set; }
      
    }
}
