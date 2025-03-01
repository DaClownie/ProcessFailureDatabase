using ProcessFailureDatabase.Shared.Models.ValueStream;

namespace ProcessFailureDatabase.Client.Services;

public interface IValueStreamService
{
    event Action? OnChange;
    public List<ValueStreamResponseDto> ValueStreams { get; set; }
    Task GetAllAsync();
    Task CreateAsync(ValueStreamCreateDto valueStream);
    Task UpdateAsync(ValueStreamUpdateDto valueStream);
    Task DeleteAsync(ValueStreamDeleteDto valueStream);
}