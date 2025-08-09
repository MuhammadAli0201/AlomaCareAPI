using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemSettingController : ControllerBase
    {
        private readonly AppDbContext context;

        public SystemSettingController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{key}")]
        public async Task<ActionResult<IEnumerable<Faq>>> GetSystemSetting(string key)
        {
            var response = await context.SystemSettings.Where(s=>s.Key==key).FirstOrDefaultAsync();
            return Ok(response);
        }

        [HttpPut("{key}")]
        public async Task<IActionResult> PutSystemSetting(string key, SystemSetting systemSetting)
        {
            if (string.IsNullOrEmpty(key))
                return BadRequest();

            await context.SystemSettings
                .Where(s => s.Key == key)
                .ExecuteUpdateAsync(property =>
            property.SetProperty(s => s.Value, systemSetting.Value));

            return NoContent();
        }
    }
}
