using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ProcessFailureDatabase.Api.Entities;

namespace ProcessFailureDatabase.Api.Data;

public partial class ProcessFailureContext : IdentityDbContext<User>
{
    public ProcessFailureContext(
        DbContextOptions<ProcessFailureContext> options) : base(options) { }

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
    
    public virtual DbSet<Touch> Touches { get; set; }
    public virtual DbSet<ProcessFailure> ProcessFailures { get; set; }
}