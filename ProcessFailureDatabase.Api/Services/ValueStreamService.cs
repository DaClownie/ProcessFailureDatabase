using ProcessFailureDatabase.Api.Entities;
using ProcessFailureDatabase.Api.Repositories;

namespace ProcessFailureDatabase.Api.Services;

public class ValueStreamService(IValueStreamRepository valueStreamRepository) : 
    IValueStreamService
{
    private readonly IValueStreamRepository _valueStreamRepository = 
        valueStreamRepository;

    public async Task<List<ValueStream>> GetAllAsync()
    {
        return [];
    }
}