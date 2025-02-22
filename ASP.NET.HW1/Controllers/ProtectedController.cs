using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize] 
[Route("api/protected")]
[ApiController]
public class ProtectedController : ControllerBase
{
    [HttpGet]
    public IActionResult GetData()
    {
        return Ok(new { message = "This is a protected route!" });
    }
}