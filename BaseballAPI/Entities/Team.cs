using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseballAPI.Entities
{
    public class Team
    {
        public int PID { get; set; }
        public string TName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string League { get; set; }
        public string Division { get; set; }

    }
}
