using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace AlomaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment environment;

        public ResourceController(AppDbContext context, IWebHostEnvironment environment)
        {
            this.context = context;
            this.environment = environment;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HelpResource>>> GetAll()
        {
            return await context.HelpResources.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HelpResource>> GetByType(int id)
        {
            return await context.HelpResources.FindAsync(id);
        }

        [HttpGet("type/{type}")]
        public async Task<ActionResult<IEnumerable<HelpResource>>> GetByType(string type)
        {
            return await context.HelpResources.Where(h=>h.Type == type).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<HelpResource>> CreateResource(HelpResource resource)
        {
            await context.HelpResources.AddAsync(resource);
            await context.SaveChangesAsync();
            return resource;
        }

        [HttpPost("upload-resource")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            var imagesFolder = Path.Combine(environment.WebRootPath, "resources");

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            var resourcesCount = context.HelpResources.Count();
            var extension = Path.GetExtension(file.FileName);
            var fileName = $"resource{resourcesCount}_{extension}";
            var filePath = Path.Combine(imagesFolder, fileName);

            // Save new file
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(new { resourcesCount, filePath, fileName });
        }
    }
}
