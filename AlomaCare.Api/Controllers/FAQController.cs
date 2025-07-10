using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQController : ControllerBase
    {
        private readonly IFaqRepository repository;

        public FAQController(IFaqRepository repository)
        {
            this.repository = repository;
        }
        // GET: api/Faq
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Faq>>> GetFaqs()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        // GET: api/Faq/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Faq>> GetFaq(int id)
        {
            var faq = await repository.GetAsync(id);

            if (faq == null)
                return NotFound();

            return faq;
        }

        // POST: api/Faq
        [HttpPost]
        public async Task<ActionResult<Faq>> PostFaq(Faq faq)
        {
            await repository.AddAsync(faq);
            return CreatedAtAction(nameof(GetFaq), new { id = faq.Id }, faq);
        }

        // PUT: api/Faq/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaq(int id, Faq faq)
        {
            if (id != faq.Id)
                return BadRequest();

            await repository.UpdateAsync(faq);

            return NoContent();
        }

        // DELETE: api/Faq/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaq(int id)
        {
            await repository.DeleteAsync(id);

            return NoContent();
        }
    }
}
