namespace ProcessFailureDatabase.Shared.Models.Line;

public record struct LineCreateDto
(
    string Name,
    int ValueStreamId
);