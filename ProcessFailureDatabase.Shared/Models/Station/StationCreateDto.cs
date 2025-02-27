namespace ProcessFailureDatabase.Shared.Models.Station;

public record StationCreateDto
(
    string Name,
    int MachineTypeId
);