namespace ProcessFailureDatabase.Shared.Models.MachineType;

public record struct MachineTypeUpdateDto
(
    int Id,
    string Name,
    int LineId
);