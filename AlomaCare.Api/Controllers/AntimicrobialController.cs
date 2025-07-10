using AlomaCare.Data.Repositories;
using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AntimicrobialController : ControllerBase
    {
        private readonly IAntimicrobialRepository repository;

        public AntimicrobialController(IAntimicrobialRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/Fungal Organism
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Antimicrobial>>> GetAntimicrobials()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        // GET: api/Fungal Organism/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Antimicrobial>> GetAntimicrobial(int id)
        {
            var antimicrobial = await repository.GetAsync(id);
            if (antimicrobial == null)
                return NotFound();

            return antimicrobial;
        }

        // POST: api/Fungal Organism
        [HttpPost]
        public async Task<ActionResult<Antimicrobial>> PostAntimicrobial(Antimicrobial antimicrobial)
        {
            await repository.AddAsync(antimicrobial);
            return CreatedAtAction(nameof(GetAntimicrobial), new { id = antimicrobial.AntimicrobialID }, antimicrobial);
        }

        // PUT: api/Fungal Organism/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAntimicrobial(int id, Antimicrobial antimicrobial)
        {
            if (id != antimicrobial.AntimicrobialID)
                return BadRequest();

            await repository.UpdateAsync(antimicrobial);
            return NoContent();
        }

        // DELETE: api/Fungal Organism/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAntimicrobial(int id)
        {
            await repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
