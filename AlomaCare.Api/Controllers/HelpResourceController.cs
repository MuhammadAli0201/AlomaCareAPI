using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlomaCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpResourceController : ControllerBase
    {
        private readonly IHelpResourceRepository repository;
        private readonly IWebHostEnvironment environment;

        public HelpResourceController(IHelpResourceRepository repository, IWebHostEnvironment environment)
        {
            this.repository = repository;
            this.environment = environment;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HelpResource>>> GetAsync()
        {
            var response = await repository.GetAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HelpResource>> GetAsync(int id)
        {
            var response = await repository.GetAsync(id);
            return Ok(response);
        }

        [HttpGet("type/{type}")]
        public async Task<ActionResult<IEnumerable<HelpResource>>> GetByType(string type)
        {
            var response = await repository.GetByType(type);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<HelpResource>> CreateResource(HelpResource resource)
        {
            await repository.AddAsync(resource);
            return resource;
        }

        [HttpPost("upload-resource")]
        public async Task<IActionResult> UploadResource(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            var imagesFolder = Path.Combine(environment.WebRootPath, "resources");

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            var allResources = await repository.GetAsync();
            var resourcesCount = allResources.Count();
            var extension = Path.GetExtension(file.FileName);
            var fileName = $"resource{resourcesCount}_{extension}";
            var filePath = Path.Combine(imagesFolder, fileName);

            // Save new file
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(new { resourcesCount, filePath=$"/resources/{fileName}", fileName });
        }
    }
}
