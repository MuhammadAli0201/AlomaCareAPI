using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpResourcesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HelpResourcesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/HelpResources/faqs
        [HttpGet("faqs")]
        public async Task<ActionResult<IEnumerable<Faq>>> GetFaqs()
        {
            return await _context.Faqs.ToListAsync();
        }

        // GET: api/HelpResources/faqs/5
        [HttpGet("faqs/{id}")]
        public async Task<ActionResult<Faq>> GetFaq(int id)
        {
            var faq = await _context.Faqs.FindAsync(id);

            if (faq == null)
                return NotFound();

            return faq;
        }

        // POST: api/HelpResources/faqs
        [HttpPost("faqs")]
        public async Task<ActionResult<Faq>> PostFaq(Faq faq)
        {
            _context.Faqs.Add(faq);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFaq), new { id = faq.Id }, faq);
        }

        // PUT: api/HelpResources/faqs/5
        [HttpPut("faqs/{id}")]
        public async Task<IActionResult> PutFaq(int id, Faq faq)
        {
            if (id != faq.Id)
                return BadRequest();

            _context.Entry(faq).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaqExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/HelpResources/faqs/5
        [HttpDelete("faqs/{id}")]
        public async Task<IActionResult> DeleteFaq(int id)
        {
            var faq = await _context.Faqs.FindAsync(id);
            if (faq == null)
                return NotFound();

            _context.Faqs.Remove(faq);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FaqExists(int id)
        {
            return _context.Faqs.Any(e => e.Id == id);
        }
    }
}
  
