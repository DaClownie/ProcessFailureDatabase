namespace ProcessFailureDatabase.Shared.Models.Station;

public record struct StationResponseDto
(
    int Id,
    string Name,
    int MachineTypeId
);