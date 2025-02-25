using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProcessFailureDatabase.Shared.Infrastructure;
using ProcessFailureDatabase.Shared.User;

namespace ProcessFailureDatabase.Api.Data;

public partial class InfrastructureContext : IdentityDbContext<User>
{
    public InfrastructureContext(
        DbContextOptions<InfrastructureContext> options) : base(options) { }

    // Redundant but provides space for AutoIncludes
    // formatted like builder.Entity<EntityName>().Navigation
    // (e => e.Object).AutoInclude();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
    
    public virtual DbSet<ValueStream> ValueStreams { get; set; }
    public virtual DbSet<Line> Lines { get; set; }
    public virtual DbSet<MachineType> MachineTypes { get; set; }
    public virtual DbSet<Station> Stations { get; set; }
}