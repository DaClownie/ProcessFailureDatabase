namespace ProcessFailureDatabase.Api.Entities;

public class ValueStream : BaseInfrastructureEntity
{
    public List<Line>? Lines { get; set; }
}