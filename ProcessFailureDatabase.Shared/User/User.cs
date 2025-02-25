using Microsoft.AspNetCore.Identity;

namespace ProcessFailureDatabase.Shared.User;

public class User : IdentityUser
{
    [Column(TypeName = "DateTimeOffset")]
    public DateTimeOffset Created { get; set; }
    
    [Column(TypeName = "DateTimeOffset")]
    public DateTimeOffset Updated { get; set; }
}