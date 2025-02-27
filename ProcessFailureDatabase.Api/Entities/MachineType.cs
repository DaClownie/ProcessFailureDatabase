namespace ProcessFailureDatabase.Api.Entities;

public class MachineType : BaseInfrastructureEntity
{
    public required Line Line { get; set; }
    public List<Station>? Stations { get; set; }
}