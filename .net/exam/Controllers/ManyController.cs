namespace exam;
using Microsoft.AspNetCore.Mvc;

public class ManyController : Controller
{
    
        private readonly DataContext _context;
    
        public ManyController(DataContext context)
        {
            _context = context;
        }
    
        [HttpGet]
        [Route("Many")]
        public IActionResult GetMany()
        {
            return Ok(_context.Manys.ToList());
        }
    
        [HttpGet]
        [Route("Many/{id}")]
        public IActionResult GetMany(int id)
        {
            var many = _context.Manys.FirstOrDefault(m => m.Id == id);
            if (many == null)
            {
                return NotFound();
            }
            return Ok(many);
        }

        //* Get all many by a condition
        // //get all many by one id
        // [HttpGet]
        // [Route("Many/One/{id}")]
        // public IActionResult GetManyByOne(int id)
        // {
        //     var many = _context.Manys.Where(m => m.Id == id).ToList();
        //     if (many == null)
        //     {
        //         return NotFound();
        //     }
        //     return Ok(many);
        // }
    
        [HttpPost]
        [Route("Many")]
        public IActionResult PostMany([FromBody] Many many)
        {
            _context.Manys.Add(many);
            _context.SaveChanges();
            return Ok(many);
        }
    
        [HttpPut]
        [Route("Many")]
        public IActionResult PutMany([FromBody] Many many)
        {
            var manyDb = _context.Manys.FirstOrDefault(m => m.Id == many.Id);
            if (manyDb == null)
            {
                return NotFound();
            }
            manyDb.Name = many.Name;
            _context.SaveChanges();
            return Ok(manyDb);
        }
    
        [HttpDelete]
        [Route("Many")]
        public IActionResult DeleteMany([FromBody] Many many)
        {
            var manyDb = _context.Manys.FirstOrDefault(m => m.Id == many.Id);
            if (manyDb == null)
            {
                return NotFound();
            }
            _context.Manys.Remove(manyDb);
            _context.SaveChanges();
            return Ok(manyDb);
        }
}

