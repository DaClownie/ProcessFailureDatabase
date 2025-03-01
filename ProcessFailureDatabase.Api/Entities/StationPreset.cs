namespace ProcessFailureDatabase.Api.Entities;

public class StationPreset
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Station> Stations { get; set; }
}