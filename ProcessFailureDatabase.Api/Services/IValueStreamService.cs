using ProcessFailureDatabase.Api.Entities;

namespace ProcessFailureDatabase.Api.Services;

public interface IValueStreamService
{
    Task<List<ValueStream>> GetAllAsync();
}