namespace exam;

using Microsoft.AspNetCore.Mvc;
using System.Linq;

[ApiController]
public class UserController : Controller
{

    private readonly DataContext _context;

    public UserController(DataContext context)
    {
        _context = context;
    }

    [HttpPost]
    [Route("Login")]
    public IActionResult Login([FromBody] User user)
    {
        var userDb = _context.Users.FirstOrDefault(u => u.Name == user.Name && u.Description == user.Description);
        if (userDb == null)
        {
            return NotFound();
        }
        return Ok(userDb);
    }

    [HttpPost]
    [Route("Register")]
    public IActionResult Register([FromBody] User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok(user);
    }



}
