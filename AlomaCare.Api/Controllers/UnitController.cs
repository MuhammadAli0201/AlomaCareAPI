using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IUnitRepository repository;

        public UnitController(IUnitRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Unit>>> GetCities()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Unit>> GetUnit(int id)
        {
            var response = await repository.GetAsync(id);
            if (response == null)
                return NotFound();

            return response;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> PostCity(Unit unit)
        {
            await repository.AddAsync(unit);
            return CreatedAtAction(nameof(GetUnit), new { id = unit.UnitId }, unit);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnit(int id, Unit unit)
        {
            if (id != unit.UnitId)
                return BadRequest();

            await repository.UpdateAsync(unit);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            await repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
