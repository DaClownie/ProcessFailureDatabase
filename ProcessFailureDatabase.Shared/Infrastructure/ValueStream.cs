namespace ProcessFailureDatabase.Shared.Infrastructure;

public class ValueStream : BaseInfrastructureEntity
{
    // TODO: DataAnnotations needed for EF Database creation
    public List<Line>? Lines { get; set; }
}