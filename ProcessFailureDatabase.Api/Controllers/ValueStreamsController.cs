using Microsoft.AspNetCore.Mvc;
using ProcessFailureDatabase.Api.Services;
using ProcessFailureDatabase.Shared.Models.ValueStream;

namespace ProcessFailureDatabase.Api.Controllers;

[Route("api/value-streams")]
[ApiController]
public class ValueStreamsController : ControllerBase
{
    private readonly IValueStreamService _valueStreamService;

    public ValueStreamsController(IValueStreamService valueStreamService)
    {
        _valueStreamService = valueStreamService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ValueStreamResponseDto>>> GetValueStreams()
    {
        var result = await _valueStreamService.GetAllAsync();
        if (result.Count is 0)
        {
            return NotFound();
        }
        return Ok(result);
    }

    // BUG: May not need? When would I return just a single ValueStream
    [HttpGet("{id}")]
    public ActionResult<ValueStreamResponseDto?> GetValueStream(int id)
    {
        // BUG: IMPLEMENT
        ValueStreamResponseDto? value = null;
        
        return value;
    }

    [HttpPost]
    public ActionResult CreateValueStream(ValueStreamCreateDto newValueStream)
    {
        // BUG: IMPLEMENT
        ValueStreamResponseDto? value = null;
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult UpdateValueStream(int id, 
        ValueStreamUpdateDto updateValueStream)
    {
        // BUG: IMPLEMENT
        ValueStreamResponseDto? value = null;
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteValueStream(int id, 
        ValueStreamDeleteDto deleteValueStream)
    {
        // BUG: IMPLEMENT
        ValueStreamResponseDto? value = null;
        return Ok();
    }
}