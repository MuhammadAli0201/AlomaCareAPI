using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AlomaCareAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MaternalController : ControllerBase
{
    private readonly AppDbContext _context;

    public MaternalController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrUpdate([FromBody] Maternal maternal)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userIdClaim = User.FindFirst(ClaimTypes.Sid)?.Value;
        if (userIdClaim == null)
            return Unauthorized();

        var patientExists = await _context.Patients.AnyAsync(p => p.Id == maternal.PatientId);
        if (!patientExists)
            return BadRequest($"Patient {maternal.PatientId} not found.");

        Maternal dbEntity = null;

        if (maternal.Id != Guid.Empty)
        {
            dbEntity = await _context.Maternals.FirstOrDefaultAsync(m => m.Id == maternal.Id);
        }

        if (dbEntity != null)
        {
            dbEntity.HospitalNumber = maternal.HospitalNumber;
            dbEntity.Parity = maternal.Parity;
            dbEntity.Gravidity = maternal.Gravidity;
            dbEntity.InitialDiagnosis = maternal.InitialDiagnosis;
            dbEntity.AntenatalCare = maternal.AntenatalCare;
            dbEntity.AntenatalSteroid = maternal.AntenatalSteroid;
            dbEntity.AntenatalMgSulfate = maternal.AntenatalMgSulfate;
            dbEntity.Chorioamnionitis = maternal.Chorioamnionitis;
            dbEntity.Hypertension = maternal.Hypertension;
            dbEntity.MaternalHiv = maternal.MaternalHiv;
            dbEntity.HivProphylaxis = maternal.HivProphylaxis;
            dbEntity.HaartBegun = maternal.HaartBegun;
            dbEntity.Syphilis = maternal.Syphilis;
            dbEntity.SyphilisTreated = maternal.SyphilisTreated;
            dbEntity.Diabetes = maternal.Diabetes;
            dbEntity.Tb = maternal.Tb;
            dbEntity.TbTreatment = maternal.TbTreatment;
            dbEntity.TeenageMother = maternal.TeenageMother;
            dbEntity.AbandonedBaby = maternal.AbandonedBaby;
            dbEntity.NeonatalAbstinence = maternal.NeonatalAbstinence;
            dbEntity.OtherInfo = maternal.OtherInfo;
            dbEntity.MultipleGestations = maternal.MultipleGestations;
            dbEntity.NumberOfBabies = maternal.NumberOfBabies;
            dbEntity.Name = maternal.Name;
            dbEntity.Surname = maternal.Surname;
            dbEntity.age = maternal.age;
            dbEntity.Race = maternal.Race;

            _context.Entry(dbEntity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(dbEntity);
        }
        else
        {
            maternal.Id = Guid.NewGuid();
            maternal.CreatedAt = DateTime.UtcNow;

            await _context.Maternals.AddAsync(maternal);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = maternal.Id }, maternal);
        }
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var list = _context.Maternals
            .OrderBy(m => m.CreatedAt)
            .ToList();
        return Ok(list);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var item = _context.Maternals.Find(id);
        if (item == null)
            return NotFound();
        return Ok(item);
    }

    [HttpGet("patientId/{id}")]
    public async Task<IActionResult> GetByPatientId(Guid id)
    {
        var item = await  _context.Maternals.FirstOrDefaultAsync(x => x.PatientId == id);
        return Ok(item);
    }
}
