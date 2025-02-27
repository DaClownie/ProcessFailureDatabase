namespace ProcessFailureDatabase.Shared.Models.Line;

public class LineDto
{
    [Required, MinLength(3, ErrorMessage = "Line must be at least 3 characters long.")]
    public string Name { get; set; }
    [Required]
    public int ValueStreamId { get; set; }
}