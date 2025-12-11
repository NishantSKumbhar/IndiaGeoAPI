using System.ComponentModel.DataAnnotations;

namespace IndiaGeoAPI.Models.Domain_Model
{
    public class StateDomainModel
    {
        [Required]
        public Guid StateID { get; set; }

        
        public required string StateName { get; set; }
        
        public string? StateCode { get; set; }
        public string? StateCensusCode { get; set; }
        public DateTime StateCreatedAt { get; set; } = DateTime.Now;

    }
}
