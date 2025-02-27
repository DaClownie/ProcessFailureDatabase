namespace ProcessFailureDatabase.Api.Entities;

public class Station : BaseInfrastructureEntity
{
    public required MachineType MachineType { get; set; }
}