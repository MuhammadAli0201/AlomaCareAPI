using AlomaCare.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlomaCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController(IlookupRepository IlookupRepository) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByCategoryId(Guid id)
        {
            var res = await IlookupRepository.GetByCategoryId(id);
            return Ok(res);
        }
    }
}
