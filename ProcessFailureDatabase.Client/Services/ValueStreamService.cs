using System.Net.Http.Json;
using ProcessFailureDatabase.Shared.Models.ValueStream;

namespace ProcessFailureDatabase.Client.Services;

public class ValueStreamService : IValueStreamService
{
    private readonly HttpClient _httpClient;
    public ValueStreamService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<ValueStreamResponseDto> ValueStreams { get; set; } = [];

    public event Action? OnChange;

    public async Task GetAllAsync()
    {
        var result = await _httpClient
            .GetFromJsonAsync<List<ValueStreamResponseDto>>("api/value-streams");
        if (result is not null)
        {
            ValueStreams = result
                .OrderBy(x => x.Name)
                .ToList();
            OnChange?.Invoke();
        }
    }

    public async Task CreateAsync(ValueStreamCreateDto valueStream)
    {
        await _httpClient.PostAsJsonAsync("api/value-streams", valueStream);
    }

    public async Task UpdateAsync(ValueStreamUpdateDto valueStream)
    {
        await _httpClient.PutAsJsonAsync($"api/value-streams/{valueStream.Id}", 
            valueStream);
    }

    public async Task DeleteAsync(ValueStreamDeleteDto valueStream)
    {
        await _httpClient.DeleteAsync($"api/value-streams/{valueStream.Id}");
    }
}