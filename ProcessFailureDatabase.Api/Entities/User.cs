using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ProcessFailureDatabase.Api.Entities;

public class User : IdentityUser
{
    [Required, Column(TypeName = "DateTimeOffset")]
    public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    [Column(TypeName = "DateTimeOffset")]
    public DateTimeOffset? Updated { get; set; }
}