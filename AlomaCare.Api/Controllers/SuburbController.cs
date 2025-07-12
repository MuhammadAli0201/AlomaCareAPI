using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuburbController : ControllerBase
    {
        private readonly ISuburbRepository repository;

        public SuburbController(ISuburbRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Suburb>>> GetSuburbs()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Suburb>> GetSuburb(int id)
        {
            var response = await repository.GetAsync(id);
            if (response == null)
                return NotFound();

            return response;
        }

        [HttpGet("city/{cityId}")]
        public async Task<ActionResult<List<Suburb>>> GetByCityId(int cityId)
        {
            var response = await repository.GetByCityIdAsync(cityId);
            if (response == null)
                return NotFound();

            return response;
        }

        [HttpPost]
        public async Task<ActionResult<Suburb>> PostSuburb(Suburb suburb)
        {
            await repository.AddAsync(suburb);
            return CreatedAtAction(nameof(GetSuburb), new { id = suburb.SuburbId }, suburb);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuburb(int id, Suburb suburb)
        {
            if (id != suburb.SuburbId)
                return BadRequest();

            await repository.UpdateAsync(suburb);
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
