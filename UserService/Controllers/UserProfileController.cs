using Microsoft.AspNetCore.Mvc;
using UserService.Models;

namespace UserService.Controllers;

[ApiController]
[Route("[controller]")]
public class UserProfileController : ControllerBase
{

    private readonly ILogger<UserProfileController> _logger;

    public UserProfileController(ILogger<UserProfileController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "")]
    public IEnumerable<User> Get()
    {
        return new List<User>();
    }
}
