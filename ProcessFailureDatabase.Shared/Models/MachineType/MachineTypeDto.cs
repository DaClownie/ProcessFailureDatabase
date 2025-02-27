namespace ProcessFailureDatabase.Shared.Models.MachineType;

public class MachineTypeDto
{
    [Required, MinLength(3, ErrorMessage = "Machine Type must be at least 3 characters long.")]
    public string Name { get; set; }
    [Required]
    public int LineId { get; set; }
}