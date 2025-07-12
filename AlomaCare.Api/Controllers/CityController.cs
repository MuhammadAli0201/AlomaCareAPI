using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository repository;

        public CityController(ICityRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            var response = await repository.GetAsync(id);
            if (response == null)
                return NotFound();

            return response;
        }

        [HttpGet("province/{provinceId}")]
        public async Task<ActionResult<List<City>>> GetCityByProvinceId(int provinceId)
        {
            var response = await repository.GetByProvinceIdAsync(provinceId);
            if (response == null)
                return NotFound();

            return response;
        }

        [HttpPost]
        public async Task<ActionResult<City>> PostCity(City city)
        {
            await repository.AddAsync(city);
            return CreatedAtAction(nameof(GetCity), new { id = city.CityId }, city);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity(int id, City city)
        {
            if (id != city.CityId)
                return BadRequest();

            await repository.UpdateAsync(city);
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
