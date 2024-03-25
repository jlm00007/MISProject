using System.ComponentModel.DataAnnotations;

namespace BaseballSiteAPI.Entities
{
    public class Team
    {
        public short TID { get; set; }
        public required string TName { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string League { get; set; }
        public required string Division { get; set; }
    }
}