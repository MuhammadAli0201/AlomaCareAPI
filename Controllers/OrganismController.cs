using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganismController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrganismController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Organism
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organism>>> GetOrganisms()
        {
            return await _context.Organisms.ToListAsync();
        }

        // GET: api/Organism/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organism>> GetOrganism(int id)
        {
            var organism = await _context.Organisms.FindAsync(id);

            if (organism == null)
                return NotFound();

            return organism;
        }

        // POST: api/Organism
        [HttpPost]
        public async Task<ActionResult<Organism>> PostOrganism(Organism organism)
        {
            _context.Organisms.Add(organism);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrganism), new { id = organism.OrganismID }, organism);
        }

        // PUT: api/Organism/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganism(int id, Organism organism)
        {
            if (id != organism.OrganismID)
                return BadRequest();

            _context.Entry(organism).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Organisms.Any(e => e.OrganismID == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/Organism/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrganism(int id)
        {
            var organism = await _context.Organisms.FindAsync(id);
            if (organism == null)
                return NotFound();

            _context.Organisms.Remove(organism);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
