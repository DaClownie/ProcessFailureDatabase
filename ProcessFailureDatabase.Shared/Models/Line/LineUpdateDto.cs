namespace ProcessFailureDatabase.Shared.Models.Line;

public record struct LineUpdateDto
(
    int Id,
    string Name,
    int ValueStreamId
);