namespace ProcessFailureDatabase.Shared.Infrastructure;

public class Station : BaseInfrastructureEntity
{
    // TODO: DataAnnotations needed for EF Database creation
    public required MachineType MachineType { get; set; }
}