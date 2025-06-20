using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using AlomaCareAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCareAPI.Controllers
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
            var fungalOrganisms = await _fungalRepo.GetAllAsync();
            return Ok(fungalOrganisms);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FungalOrganism>> GetFungalOrganism(int id)
        {
            var fungalOrganism = await _fungalRepo.GetByIdAsync(id);
            if (fungalOrganism == null)
                return NotFound();

            return Ok(fungalOrganism);
        }

        [HttpPost]
        public async Task<ActionResult<FungalOrganism>> PostFungalOrganism(FungalOrganism fungalOrganism)
        {
            await _fungalRepo.AddAsync(fungalOrganism);
            await _fungalRepo.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFungalOrganism), new { id = fungalOrganism.FungalOrganismID }, fungalOrganism);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFungalOrganism(int id, FungalOrganism fungalOrganism)
        {
            if (id != fungalOrganism.FungalOrganismID)
                return BadRequest();

            _fungalRepo.Update(fungalOrganism);

            try
            {
                await _fungalRepo.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var exists = await _fungalRepo.GetByIdAsync(id);
                if (exists == null)
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFungalOrganism(int id)
        {
            var fungalOrganism = await _fungalRepo.GetByIdAsync(id);
            if (fungalOrganism == null)
                return NotFound();

            _fungalRepo.Delete(fungalOrganism);
            await _fungalRepo.SaveChangesAsync();

            return NoContent();
        }
    }
}