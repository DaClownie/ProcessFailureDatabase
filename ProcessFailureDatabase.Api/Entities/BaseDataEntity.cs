using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProcessFailureDatabase.Api.Entities;

public class BaseDataEntity
{
    [Key]
    public int Id { get; set; }
    [Required, Column(TypeName = "DateTimeOffset")]
    public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    [Column(TypeName = "DateTimeOffset")]
    public DateTimeOffset? Updated { get; set; }
    
    public List<User> Users { get; set; } = new();
}