using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProcessFailureDatabase.Api.Entities;

public class BaseDataEntity
{
    [Key]
    public int Id { get; set; }
    [Required, Column(TypeName = "timestamp with time zone")]
    public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    [Column(TypeName = "timestamp with time zone")]
    public DateTimeOffset? Updated { get; set; }
    
    public List<User> Users { get; set; } = new();
}