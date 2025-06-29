using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlomaCareAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientCompleteInfoController(AppDbContext context) : ControllerBase
{

    [HttpGet("{patientId:guid}")]
    public async Task<IActionResult> GetByPatientId(Guid patientId)
    {
        var patientCompleteInfos = await context.PatientCompleteInfos
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.PatientId == patientId);

        return Ok(patientCompleteInfos);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrUpdate([FromBody] PatientCompleteInfo input)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var existing = await context.PatientCompleteInfos
            .FirstOrDefaultAsync(m => m.PatientId == input.PatientId);

        if (existing == null)
        {
            input.Id = Guid.NewGuid();
            await context.PatientCompleteInfos.AddAsync(input);
        }
        else
        {
            context.Entry(existing).CurrentValues.SetValues(input);
            existing.CongenitalInfectionOrganism = input.CongenitalInfectionOrganism;
            existing.BsOrganism = input.BsOrganism;
            existing.SepsisSite = input.SepsisSite;
            existing.FungalOrganism = input.FungalOrganism;
            existing.LateSepsisAbx = input.LateSepsisAbx;
            existing.SonarFindings = input.SonarFindings;
            existing.RespiratoryDiagnosis = input.RespiratoryDiagnosis;
            existing.RespSupportAfter = input.RespSupportAfter;
            existing.AeeGNotDoneReason = input.AeeGNotDoneReason;
            existing.CoolingNotDoneReason = input.CoolingNotDoneReason;
            existing.CoolingType = input.CoolingType;
            existing.TypeNecSurgery = input.TypeNecSurgery;
            existing.RopFindings = input.RopFindings;
            existing.RopSurgery = input.RopSurgery;
            existing.MetabolicComplications = input.MetabolicComplications;
            existing.GlucoseAbnormalities = input.GlucoseAbnormalities;
            existing.KmcType = input.KmcType;
        }

        await context.SaveChangesAsync();
        return Ok(input);
    }
}
