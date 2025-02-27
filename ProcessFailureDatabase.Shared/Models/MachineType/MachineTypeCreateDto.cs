namespace ProcessFailureDatabase.Shared.Models.MachineType;

public record struct MachineTypeCreateDto
(
    string Name,
    int LineId
);