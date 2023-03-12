using Microsoft.AspNetCore.Mvc;
using RobotSocialAPI.Models;

namespace RobotSocialAPI.Controllers;

[ApiController]
[Route("api/v0/[controller]")]
public class UsersController : ControllerBase
{
  private static readonly string[] FirstNames = new[]
  {
    "Carol", "Julie", "Bob", "Rex", "Taylor", "Cory", "Lara", "Jamie", "Joel"
  };

  private static readonly string[] LastNames = new[]
  {
    "Smith", "Red", "Jones", "Johnson", "Jackson", "Gibson", "Chavez", "Brave"
  };

  private readonly ILogger<UsersController> _logger;

  public UsersController(ILogger<UsersController> logger)
  {
    _logger = logger;
  }

  [HttpGet(Name = "GetUsers")]
  public IEnumerable<User> Get()
  {
    return Enumerable.Range(1, 5).Select(index => new User
    {
      DateCreated = DateTime.Now.AddDays(index),
      DateModified = DateTime.Now,
      FirstName = FirstNames[Random.Shared.Next(FirstNames.Length)],
      LastName = LastNames[Random.Shared.Next(LastNames.Length)],
      EmailAddress = $"Test{index}@test.com",
      Password = "Password"
    })
    .ToArray();
  }
}
