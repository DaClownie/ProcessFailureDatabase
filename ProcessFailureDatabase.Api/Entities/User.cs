using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ProcessFailureDatabase.Api.Entities;

public class User : IdentityUser
{
    [Required, Column(TypeName = "timestamp with time zone")]
    public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    [Column(TypeName = "timestamp with time zone")]
    public DateTimeOffset? Updated { get; set; }
}