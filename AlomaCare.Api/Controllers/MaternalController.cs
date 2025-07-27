using AlomaCare.Context;
using AlomaCare.Data.Repositories;
using AlomaCare.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AlomaCare.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MaternalController : ControllerBase
{
    private readonly IMaternalRepository repository;
    private readonly IPatientRepository patientRepository;

    public MaternalController(IMaternalRepository repository, IPatientRepository patientRepository)
    {
        this.repository = repository;
        this.patientRepository = patientRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrUpdate([FromBody] Maternal maternal)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userIdClaim = User.FindFirst(ClaimTypes.Sid)?.Value;
        if (userIdClaim == null)
            return Unauthorized();

        var existingPatient = await patientRepository.GetAsync(maternal.PatientId);
        if (existingPatient == null)
            return BadRequest($"Patient {maternal.PatientId} not found.");

        Maternal dbEntity = await repository.GetAsync(maternal.Id);

        //if (maternal.Id != Guid.Empty)
        //{
        //    dbEntity = await _context.Maternals.FirstOrDefaultAsync(m => m.Id == maternal.Id);
        //}

        if (dbEntity != null)
        {
            dbEntity.HospitalNumber = maternal.HospitalNumber;
            dbEntity.Parity = maternal.Parity;
            dbEntity.Gravidity = maternal.Gravidity; 
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

            await repository.UpdateAsync(dbEntity);
            return Ok(dbEntity);
        }
        else
        {
            maternal.Id = Guid.NewGuid();
            maternal.CreatedAt = DateTime.UtcNow;

            await repository.AddAsync(maternal);
            return CreatedAtAction(nameof(GetById), new { id = maternal.Id }, maternal);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var list = await repository.GetMaternalsFromStoredProcedure();
        return Ok(list);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var item = repository.GetAsync(id);
        if (item == null)
            return NotFound();
        return Ok(item);
    }

    [HttpGet("patientId/{id}")]
    public async Task<IActionResult> GetByPatientId(Guid id)
    {
        var item = await repository.GetByPatientId(id);
        return Ok(item);
    }
}
