using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PlacesController : ControllerBase
{
    private readonly SupabaseService _service;

    public PlacesController(SupabaseService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _service.GetPlacesAsync();
        return Ok(result);
    }
    [HttpGet("{city}")]
    public async Task<IActionResult> GetByCity(string city)
    {
        var result = await _service.GetPlacesByCityAsync(city);
        return Ok(result);
    }
}
