using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AntimicrobialController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AntimicrobialController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Fungal Organism
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Antimicrobial>>> GetAntimicrobials()
        {
            return await _context.Antimicrobials.ToListAsync();
        }

        // GET: api/Fungal Organism/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Antimicrobial>> GetAntimicrobial(int id)
        {
            var antimicrobial = await _context.Antimicrobials.FindAsync(id);

            if (antimicrobial == null)
                return NotFound();

            return antimicrobial;
        }

        // POST: api/Fungal Organism
        [HttpPost]
        public async Task<ActionResult<Antimicrobial>> PostAntimicrobial(Antimicrobial antimicrobial)
        {
            _context.Antimicrobials.Add(antimicrobial);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAntimicrobial), new { id = antimicrobial.AntimicrobialID }, antimicrobial);
        }

        // PUT: api/Fungal Organism/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAntimicrobial(int id, Antimicrobial antimicrobial)
        {
            if (id != antimicrobial.AntimicrobialID)
                return BadRequest();

            _context.Entry(antimicrobial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Antimicrobials.Any(e => e.AntimicrobialID == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/Fungal Organism/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAntimicrobial(int id)
        {
            var antimicrobial = await _context.Antimicrobials.FindAsync(id);
            if (antimicrobial == null)
                return NotFound();

            _context.Antimicrobials.Remove(antimicrobial);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
