using Microsoft.AspNetCore.Mvc;

namespace SMGE_API_VAL_TICKET.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] LogRequest request)
    {
        var line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {request.Message}{Environment.NewLine}";

        var path = Path.Combine(AppContext.BaseDirectory, "validation.log");

        await System.IO.File.AppendAllTextAsync(path, line);

        return Ok(new { status = "logged" });

    }
}

