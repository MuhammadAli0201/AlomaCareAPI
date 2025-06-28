using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AlomaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController(AppDbContext context) : ControllerBase
    {
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateOrUpdate([FromBody] Patient patient)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                var userId = User.FindFirst(ClaimTypes.Sid)?.Value;
                if (userId == null) return Unauthorized();

                Patient dbPatient = null;

                if (patient.Id != Guid.Empty)
                {
                    dbPatient = await context.Patients.FindAsync(patient.Id);
                }

                if (dbPatient != null)
                {
                    dbPatient.HospitalNumber = patient.HospitalNumber;
                    dbPatient.Name = patient.Name;
                    dbPatient.Surname = patient.Surname;
                    dbPatient.DateOfBirth = patient.DateOfBirth;
                    dbPatient.DateOfAdmission = patient.DateOfAdmission;
                    dbPatient.AgeOnAdmission = patient.AgeOnAdmission;
                    dbPatient.BirthWeight = patient.BirthWeight;
                    dbPatient.GestationalUnit = patient.GestationalUnit;
                    dbPatient.GestationalAge = patient.GestationalAge;
                    dbPatient.Gender = patient.Gender;
                    dbPatient.PlaceOfBirth = patient.PlaceOfBirth;
                    dbPatient.ModeOfDelivery = patient.ModeOfDelivery;
                    dbPatient.InitialResuscitation = patient.InitialResuscitation;
                    dbPatient.OneMinuteApgar = patient.OneMinuteApgar;
                    dbPatient.FiveMinuteApgar = patient.FiveMinuteApgar;
                    dbPatient.TenMinuteApgar = patient.TenMinuteApgar;
                    dbPatient.OutcomeStatus = patient.OutcomeStatus;
                    dbPatient.TransferHospital = patient.TransferHospital;
                    dbPatient.BirthHivPcr = patient.BirthHivPcr;
                    dbPatient.HeadCircumference = patient.HeadCircumference;
                    dbPatient.FootLength = patient.FootLength;
                    dbPatient.LengthAtBirth = patient.LengthAtBirth;
                    dbPatient.DiedInDeliveryRoom = patient.DiedInDeliveryRoom;
                    dbPatient.DiedWithin12Hours = patient.DiedWithin12Hours;
                    dbPatient.InitialTemperature = patient.InitialTemperature;
                    // Do not update CreatedByUserId for updates

                    context.Patients.Update(dbPatient);
                    await context.SaveChangesAsync();
                    return Ok(dbPatient);
                }
                else
                {
                    // Create new patient
                    patient.Id = Guid.NewGuid();
                    patient.CreatedByUserId = int.Parse(userId);
                    await context.Patients.AddAsync(patient);
                    await context.SaveChangesAsync();
                    return CreatedAtAction(nameof(GetById), new { id = patient.Id }, patient);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = context.Patients.ToList();
            return Ok(list);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var patient = await context.Patients.FirstOrDefaultAsync(x => x.Id == id);
            if (patient == null) return NotFound();
            context.Patients.Remove(patient);
            await context.SaveChangesAsync();
            return Ok(true);
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var patient = context.Patients
                .Where(p => p.Id == id)
                .FirstOrDefault();
            if (patient == null) return NotFound();
            return Ok(patient);
        }
        
        [Authorize]
        [HttpGet("search/{searchInput?}")]
        public async Task<IActionResult> Search(string? searchInput)
        {
            if (string.IsNullOrWhiteSpace(searchInput))
                return Ok(await context.Patients.ToListAsync());

            var search = context.Patients
                .Where(p =>
                    p.HospitalNumber.Contains(searchInput) ||
                    p.Name.Contains(searchInput) ||
                    p.Surname.Contains(searchInput) ||
                    p.Gender.Contains(searchInput))
                .ToList();

            return Ok(search);
        }
    }
}

