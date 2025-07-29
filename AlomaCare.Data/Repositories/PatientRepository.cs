using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        private readonly AppDbContext context;

        public PatientRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<Patient>> GetPatientsByAdmissionMonth(int month)
        {
            var patients = await context.Patients.Where(p => p.DateOfAdmission.Month == month).ToListAsync();
            return patients;
        }

        public async Task<List<Patient>> GetPatientsFromStoredProcedure()
        {
            var patients = await context.Patients
            .FromSqlRaw("EXEC [dbo].[GetAllPatients]")
            .ToListAsync();
            return patients;
        }
    }
}
