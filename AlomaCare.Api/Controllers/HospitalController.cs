using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalRepository repository;

        public HospitalController(IHospitalRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hospital>>> GetHospitals()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hospital>> GetHospital(int id)
        {
            var response = await repository.GetAsync(id);
            if (response == null)
                return NotFound();

            return response;
        }

        [HttpGet("suburb/{suburbId}")]
        public async Task<ActionResult<List<Hospital>>> GetBySuburbId(int suburbId)
        {
            var response = await repository.GetBySuburbIdAsync(suburbId);
            if (response == null)
                return NotFound();

            return response;
        }

        [HttpPost]
        public async Task<ActionResult<Hospital>> PostHospital(Hospital hospital)
        {
            await repository.AddAsync(hospital);
            return CreatedAtAction(nameof(GetHospital), new { id = hospital.HospitalId }, hospital);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospital(int id, Hospital hospital)
        {
            if (id != hospital.HospitalId)
                return BadRequest();

            await repository.UpdateAsync(hospital);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospital(int id)
        {
            await repository.DeleteAsync(id);
            return NoContent();
        }

    }
}
