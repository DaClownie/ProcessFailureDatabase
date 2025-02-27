using System.ComponentModel.DataAnnotations;

namespace ProcessFailureDatabase.Api.Entities;

public class BaseInfrastructureEntity
{
    [Key]
    public int Id { get; set; }
    [Required, MaxLength(64)]
    public string Name { get; set; }
}