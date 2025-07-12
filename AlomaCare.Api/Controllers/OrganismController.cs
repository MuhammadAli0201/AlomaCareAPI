using AlomaCare.Context;
using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganismController : ControllerBase
    {
        private readonly IOrganismRepository repository;

        public OrganismController(IOrganismRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/Organism
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organism>>> GetOrganisms()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        // GET: api/Organism/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organism>> GetOrganism(int id)
        {
            var organism = await repository.GetAsync(id);

            if (organism == null)
                return NotFound();

            return organism;
        }

        // POST: api/Organism
        [HttpPost]
        public async Task<ActionResult<Organism>> PostOrganism(Organism organism)
        {
            await repository.AddAsync(organism);

            return CreatedAtAction(nameof(GetOrganism), new { id = organism.OrganismID }, organism);
        }

        // PUT: api/Organism/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganism(int id, Organism organism)
        {
            if (id != organism.OrganismID)
                return BadRequest();

            await repository.UpdateAsync(organism);

            return NoContent();
        }

        // DELETE: api/Organism/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrganism(int id)
        {
            await repository.DeleteAsync(id);

            return NoContent();
        }
    }
}
