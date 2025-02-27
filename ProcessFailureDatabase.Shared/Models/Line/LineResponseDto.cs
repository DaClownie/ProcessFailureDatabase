namespace ProcessFailureDatabase.Shared.Models.Line;

public record struct LineResponseDto
(
    int Id,
    string Name,
    int ValueStreamId
);