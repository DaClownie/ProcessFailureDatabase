namespace ProcessFailureDatabase.Api.Entities;

public class Line : BaseInfrastructureEntity
{
    public required ValueStream ValueStream { get; set; }
    public List<MachineType>? MachineTypes { get; set; }
}