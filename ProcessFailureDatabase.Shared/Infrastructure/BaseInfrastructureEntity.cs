using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ProcessFailureDatabase.Shared.Infrastructure;

public class BaseInfrastructureEntity
{
    // TODO: DataAnnotations needed for EF Database creation
    public int Id { get; set; }
    public string Name { get; set; }
}