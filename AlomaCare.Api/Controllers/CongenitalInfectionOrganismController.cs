using AlomaCare.Data.Repositories;
using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongenitalInfectionOrganismController : ControllerBase
    {
        private readonly ICongenitalInfectionOrganism repository;

        public CongenitalInfectionOrganismController(ICongenitalInfectionOrganism repository)
        {
            this.repository = repository;
        }

        // GET: api/Fungal Organism
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CongenitalInfectionOrganism>>> GetCongenitalInfectionOrganisms()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        // GET: api/Fungal Organism/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CongenitalInfectionOrganism>> GetCongenitalInfectionOrganism(int id)
        {
            var congenitalInfectionOrganism = await repository.GetAsync(id);

            if (congenitalInfectionOrganism == null)
                return NotFound();

            return congenitalInfectionOrganism;
        }

        // POST: api/Fungal Organism
        [HttpPost]
        public async Task<ActionResult<CongenitalInfectionOrganism>> PostCongenitalInfectionOrganism(CongenitalInfectionOrganism congenitalInfectionOrganism)
        {

            var response = await repository.AddAsync(congenitalInfectionOrganism);

            return CreatedAtAction(nameof(GetCongenitalInfectionOrganism),
                new { id = congenitalInfectionOrganism.CongenitalInfectionOrganismID },
                congenitalInfectionOrganism);
        }

        // PUT: api/Fungal Organism/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCongenitalInfectionOrganism(int id, CongenitalInfectionOrganism congenitalinfectionorganism)
        {
            if (id != congenitalinfectionorganism.CongenitalInfectionOrganismID)
                return BadRequest();

            await repository.UpdateAsync(congenitalinfectionorganism);

            return NoContent();
        }

        // DELETE: api/Fungal Organism/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCongenitalInfectionOrganism(int id)
        {
            await repository.DeleteAsync(id);

            return NoContent();
        }
    }
}
