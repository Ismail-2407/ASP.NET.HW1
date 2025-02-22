using Microsoft.AspNetCore.Mvc;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto loginDto)
    {
        if (loginDto.Username == "admin" && loginDto.Password == "password") // Тут должна быть проверка из БД
        {
            var token = _authService.GenerateToken(loginDto.Username);
            return Ok(new { token });
        }
        return Unauthorized();
    }
}

public class LoginDto
{
    public string Username { get; set; }
    public string Password { get; set; }
}