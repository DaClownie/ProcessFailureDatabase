namespace ProcessFailureDatabase.Shared.Models.ValueStream;

public class ValueStreamDto
{
    [Required, MinLength(3, ErrorMessage = "Value Stream Name must be at least 3 characters long.")]
    public string Name { get; set; }
    
    
}