using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceRepository repository;

        public ProvinceController(IProvinceRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Province>>> GetProvinces()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Province>> GetProvince(int id)
        {
            var response = await repository.GetAsync(id);
            if (response == null)
                return NotFound();

            return response;
        }

        [HttpPost]
        public async Task<ActionResult<Antimicrobial>> PostProvince(Province province)
        {
            await repository.AddAsync(province);
            return CreatedAtAction(nameof(GetProvince), new { id = province.ProvinceId }, province);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvince(int id, Province province)
        {
            if (id != province.ProvinceId)
                return BadRequest();

            await repository.UpdateAsync(province);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvince(int id)
        {
            await repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
