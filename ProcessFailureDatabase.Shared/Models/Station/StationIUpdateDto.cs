namespace ProcessFailureDatabase.Shared.Models.Station;

public record StationIUpdateDto
(
    int Id,
    string Name,
    int MachineTypeId
);