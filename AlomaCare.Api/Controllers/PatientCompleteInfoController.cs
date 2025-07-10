using AlomaCare.Context;
using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientCompleteInfoController(IPatientCompleteInfoRepository repository) : ControllerBase
{

    [HttpGet("{patientId:guid}")]
    public async Task<IActionResult> GetByPatientId(Guid patientId)
    {
        var patientCompleteInfos = await repository.GetByPatientId(patientId);

        return Ok(patientCompleteInfos);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrUpdate([FromBody] PatientCompleteInfo input)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var existing = await repository.GetByPatientId(input.PatientId);

        if (existing == null)
        {
            input.Id = Guid.NewGuid();
            await repository.AddAsync(input);
        }
        else
        {
            await repository.UpdateAsync(input);
        }
        return Ok(input);
    }
}
