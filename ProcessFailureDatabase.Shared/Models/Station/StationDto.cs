namespace ProcessFailureDatabase.Shared.Models.Station;

public class StationDto
{
    [Required, MinLength(3, ErrorMessage = "Value Stream Name must be at least 3 characters long.")]
    public string Name { get; set; }
    [Required]
    public int MachineTypeId { get; set; }
}