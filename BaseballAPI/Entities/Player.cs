using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseballAPI.Entities
{
    public class Player
    {
            public int PID { get; set; }
        [Required]
            public string Name { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string TID { get; set; }
        [Required]


    }
}
