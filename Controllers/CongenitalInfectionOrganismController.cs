using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongenitalInfectionOrganismController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CongenitalInfectionOrganismController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Fungal Organism
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CongenitalInfectionOrganism>>> GetCongenitalInfectionOrganisms()
        {
            return await _context.CongenitalInfectionOrganisms.ToListAsync();
        }

        // GET: api/Fungal Organism/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CongenitalInfectionOrganism>> GetCongenitalInfectionOrganism(int id)
        {
            var congenitalinfectionorganism = await _context.CongenitalInfectionOrganisms.FindAsync(id);

            if (congenitalinfectionorganism == null)
                return NotFound();

            return congenitalinfectionorganism;
        }

        // POST: api/Fungal Organism
        [HttpPost]
        public async Task<ActionResult<CongenitalInfectionOrganism>> PostCongenitalInfectionOrganism(CongenitalInfectionOrganism congenitalinfectionorganism)
        {

            _context.CongenitalInfectionOrganisms.Add(congenitalinfectionorganism);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCongenitalInfectionOrganism),
                new { id = congenitalinfectionorganism.CongenitalInfectionOrganismID },
                congenitalinfectionorganism);
        }

        // PUT: api/Fungal Organism/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCongenitalInfectionOrganism(int id, CongenitalInfectionOrganism congenitalinfectionorganism)
        {
            if (id != congenitalinfectionorganism.CongenitalInfectionOrganismID)
                return BadRequest();

            _context.Entry(congenitalinfectionorganism).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.CongenitalInfectionOrganisms.Any(e => e.CongenitalInfectionOrganismID == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/Fungal Organism/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCongenitalInfectionOrganism(int id)
        {
            var congenitalinfectionorganism = await _context.CongenitalInfectionOrganisms.FindAsync(id);
            if (congenitalinfectionorganism == null)
                return NotFound();

            _context.CongenitalInfectionOrganisms.Remove(congenitalinfectionorganism);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
