using AlomaCare.Api.Helpers;
using AlomaCare.Context;
using AlomaCare.Data.Repositories;
using AlomaCare.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace AlomaCare.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DiagnosisTreatmentFormController(IDiagnosisTreatmentFormRepository repository, AppDbContext context) : ControllerBase
{

    [HttpGet("{patientId:guid}")]
    public async Task<IActionResult> GetByPatientId(Guid patientId)
    {
        var patientCompleteInfos = await repository.GetByPatientId(patientId);

        return Ok(patientCompleteInfos);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrUpdate([FromBody] PatientCompleteInfoDTO input)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var existing = await repository.GetByPatientId(input.PatientId);

        if (existing == null)
        {
            input.Id = Guid.NewGuid();
            await context.AuditLogs.AddAsync(
                        AuditLogHelper.GetDiagnosisAuditLog(int.Parse(User.FindFirst(ClaimTypes.Sid).Value), "Create")
                    );
            await repository.CreateAsync(input);
        }
        else
        {
            await context.AuditLogs.AddAsync(
                        AuditLogHelper.GetDiagnosisAuditLog(int.Parse(User.FindFirst(ClaimTypes.Sid).Value), "Update")
                    );
            await repository.UpdateAsync(input);
        }
        return Ok(input);
    }
}
