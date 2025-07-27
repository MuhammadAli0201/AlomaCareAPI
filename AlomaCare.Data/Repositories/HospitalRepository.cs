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
    public class HospitalRepository : Repository<Hospital>, IHospitalRepository
    {
        private readonly AppDbContext context;

        public HospitalRepository(AppDbContext context): base(context)
        {
            this.context = context;
        }

        public async Task<List<Hospital>> GetBySuburbIdAsync(int hospitalId)
        {
            return await context.Hospitals.Where(s => s.HospitalId == hospitalId).ToListAsync();
        }

        public override async Task<IEnumerable<Hospital>> GetAsync(string? includeProperties = null)
        {
            return await context.Hospitals.FromSqlRaw("EXEC [dbo].[GetAllHospitals]")
                .ToListAsync();
        }

        public override async Task<bool> DeleteAsync(object id)
        {
            var item = await context.Hospitals.FindAsync(id);
            if (item != null)
            {
                item.IsDeleted = true;
                int rowsAffected = await context.SaveChangesAsync();
                return rowsAffected > 0;
            }
            return false;
        }
    }
}
