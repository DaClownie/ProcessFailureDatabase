namespace ProcessFailureDatabase.Shared.Models.MachineType;

public record struct MachineTypeResponseDto
(
    int Id,
    string Name,
    int LineId
);