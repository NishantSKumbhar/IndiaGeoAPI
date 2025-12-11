namespace IndiaGeoAPI.Models.DTO
{
    public class StateInputDTO
    {
        public required string StateName { get; set; }

        public string? StateCode { get; set; }
        public string? StateCensusCode { get; set; }
    }
}
