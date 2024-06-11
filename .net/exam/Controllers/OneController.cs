namespace exam;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class OneController : Controller
{

    private readonly DataContext _context;

    public OneController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("One")]
    public IActionResult GetOne()
    {
        return Ok(_context.Ones.ToList());
    }

    [HttpGet]
    [Route("One/{id}")]
    public IActionResult GetOne(int id)
    {
        var one = _context.Ones.FirstOrDefault(o => o.Id == id);
        if (one == null)
        {
            return NotFound();
        }
        return Ok(one);
    }

    [HttpPost]
    [Route("One")]
    public IActionResult PostOne([FromBody] One one)
    {
        _context.Ones.Add(one);
        _context.SaveChanges();
        return Ok(one);
    }

    [HttpPut]
    [Route("One")]
    public IActionResult PutOne([FromBody] One one)
    {
        var oneDb = _context.Ones.FirstOrDefault(o => o.Id == one.Id);
        if (oneDb == null)
        {
            return NotFound();
        }
        oneDb.Name = one.Name;
        oneDb.Description = one.Description;
        _context.SaveChanges();
        return Ok(oneDb);
    }

    [HttpDelete]
    [Route("One")]
    public IActionResult DeleteOne([FromBody] One one)
    {
        var oneDb = _context.Ones.FirstOrDefault(o => o.Id == one.Id);
        if (oneDb == null)
        {
            return NotFound();
        }
        _context.Ones.Remove(oneDb);
        _context.SaveChanges();
        return Ok();
    }

}
