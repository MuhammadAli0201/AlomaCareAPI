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
    public class MaternalRepository : Repository<Maternal>, IMaternalRepository
    {
        private readonly AppDbContext context;

        public MaternalRepository(AppDbContext context):base(context)
        {
            this.context = context;
        }

        public async Task<Maternal?> GetByPatientId(Guid patientId)
        {
            var response = await context.Maternals.FirstOrDefaultAsync(x => x.PatientId == patientId);
            return response;
        }
    }
}
