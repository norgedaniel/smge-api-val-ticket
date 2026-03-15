using Microsoft.AspNetCore.Mvc;

namespace SMGE_API_VAL_TICKET.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "ok",
            service = "Parking API",
            time = DateTime.UtcNow
        });
    }
}

