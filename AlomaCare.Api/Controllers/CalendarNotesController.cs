using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarNotesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CalendarNotesController(AppDbContext context)
        {
            _context = context;
        }

        // GET notes for a given month (yyyy-MM format)
        [HttpGet]
        public async Task<IActionResult> GetNotes(string month)
        {
            if (string.IsNullOrEmpty(month))
                return BadRequest("Month parameter is required.");

            if (!DateTime.TryParse($"{month}-01", out DateTime date))
                return BadRequest("Invalid month format. Use yyyy-MM.");

            var nextMonth = date.AddMonths(1);

            var notes = await _context.CalendarNotes
                .Where(n => n.NoteDate >= date && n.NoteDate < nextMonth)
                .ToListAsync();

            return Ok(notes);
        }

        // POST: add new note
        [HttpPost]
        public async Task<IActionResult> AddNote([FromBody] CalendarNote note)
        {
            if (note == null)
                return BadRequest();

            _context.CalendarNotes.Add(note);
            await _context.SaveChangesAsync();

            return Ok(note);
        }

        // PUT: update existing note
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNote(int id, [FromBody] CalendarNote note)
        {
            if (note == null || id != note.Id)
                return BadRequest();

            var existing = await _context.CalendarNotes.FindAsync(id);
            if (existing == null)
                return NotFound();

            existing.NoteText = note.NoteText;
            existing.NoteDate = note.NoteDate;

            await _context.SaveChangesAsync();

            return Ok(existing);
        }

        // DELETE note by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote(int id)
        {
            var existing = await _context.CalendarNotes.FindAsync(id);
            if (existing == null)
                return NotFound();

            _context.CalendarNotes.Remove(existing);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}