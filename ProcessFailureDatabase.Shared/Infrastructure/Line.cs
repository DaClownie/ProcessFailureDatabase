namespace ProcessFailureDatabase.Shared.Infrastructure;

public class Line : BaseInfrastructureEntity
{
    // TODO: DataAnnotations needed for EF Database creation
    public required ValueStream ValueStream { get; set; }
    public List<MachineType>? MachineTypes { get; set; }
}