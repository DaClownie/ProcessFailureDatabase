namespace ProcessFailureDatabase.Shared.Infrastructure;

public class MachineType : BaseInfrastructureEntity
{
    // TODO: DataAnnotations needed for EF Database creation
    public required Line Line { get; set; }
    public List<Station>? Stations { get; set; }
}