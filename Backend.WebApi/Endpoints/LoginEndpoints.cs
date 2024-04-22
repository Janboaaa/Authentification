using Backend.WebApi.Data.Models;
using Backend.WebApi.Data.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Backend.WebApi.Endpoints;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly BackendDB _context;

    public UserController(BackendDB context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        User? user = _context.Users.FirstOrDefault(u => u.Name.AuthName == request.AuthName && u.Key == request.Key);
        if (user == null)
        {
            return BadRequest("Invalid authName or key.");
        }
        if (!user.RememberMe == request.RememberMe) {}

        return Ok("Login successful.");
    }
}