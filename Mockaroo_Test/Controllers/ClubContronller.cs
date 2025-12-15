using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mockaroo_Test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubContronller : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClubContronller(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Club>>> Get()
        {
            var clubs = await _context.Clubs.ToListAsync();
            return Ok(clubs);
        }
    }
}
