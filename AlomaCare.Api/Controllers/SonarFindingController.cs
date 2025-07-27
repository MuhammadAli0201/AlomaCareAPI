using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SonarFindingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SonarFindingController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Fungal Organism
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SonarFinding>>> GetSonarFindings()
        {
            return await _context.SonarFindings.ToListAsync();
        }

        // GET: api/Fungal Organism/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SonarFinding>> GetSonarFinding(int id)
        {
            var sonarfinding = await _context.SonarFindings.FindAsync(id);

            if (sonarfinding == null)
                return NotFound();

            return sonarfinding;
        }

        // POST: api/Fungal Organism
        [HttpPost]
        public async Task<ActionResult<SonarFinding>> PostSonarFinding(SonarFinding sonarfinding)
        {

            _context.SonarFindings.Add(sonarfinding);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSonarFinding),
                new { id = sonarfinding.SonarFindingID },
                sonarfinding);
        }

        // PUT: api/Fungal Organism/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSonarFinding(int id, SonarFinding sonarfinding)
        {
            if (id != sonarfinding.SonarFindingID)
                return BadRequest();

            _context.Entry(sonarfinding).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.SonarFindings.Any(e => e.SonarFindingID == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/Fungal Organism/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSonarFinding(int id)
        {
            var sonarfinding = await _context.SonarFindings.FindAsync(id);
            if (sonarfinding == null)
                return NotFound();

            sonarfinding.IsDeleted = true;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
