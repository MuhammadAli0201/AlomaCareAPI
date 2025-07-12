using AlomaCare.Data.Repositories;
using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FungalOrganismController : ControllerBase
    {
        private readonly IFungalOrganismRepository _fungalRepo;

        public FungalOrganismController(IFungalOrganismRepository fungalRepo)
        {
            _fungalRepo = fungalRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FungalOrganism>>> GetFungalOrganisms()
        {
            var fungalOrganisms = await _fungalRepo.GetAsync();
            return Ok(fungalOrganisms);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FungalOrganism>> GetFungalOrganism(int id)
        {
            var fungalOrganism = await _fungalRepo.GetAsync(id);
            if (fungalOrganism == null)
                return NotFound();

            return Ok(fungalOrganism);
        }

        [HttpPost]
        public async Task<ActionResult<FungalOrganism>> PostFungalOrganism(FungalOrganism fungalOrganism)
        {
            await _fungalRepo.AddAsync(fungalOrganism);

            return CreatedAtAction(nameof(GetFungalOrganism), new { id = fungalOrganism.FungalOrganismID }, fungalOrganism);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFungalOrganism(int id, FungalOrganism fungalOrganism)
        {
            if (id != fungalOrganism.FungalOrganismID)
                return BadRequest();

            await _fungalRepo.UpdateAsync(fungalOrganism);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFungalOrganism(int id)
        {
            await _fungalRepo.DeleteAsync(id);

            return NoContent();
        }
    }
}