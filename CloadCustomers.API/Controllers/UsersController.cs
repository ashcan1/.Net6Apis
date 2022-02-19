using Microsoft.AspNetCore.Mvc;

namespace CloadCustomers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
  
    private readonly ILogger<UserController> _logger;

    public UserController()
    {
     
    }

    [HttpGet(Name = "GetUsers")]
    public async Task<IActionResult> Get()
    {
        return null;

    }
}
