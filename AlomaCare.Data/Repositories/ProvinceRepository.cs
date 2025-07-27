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
    public class ProvinceRepository : Repository<Province>, IProvinceRepository
    {
        private readonly AppDbContext context;

        public ProvinceRepository(AppDbContext context):base(context)
        {
            this.context = context;
        }

        public Task<List<Province>> GetWithPropertiesAsync()
        {
            return context.Provinces
                .Include(p => p.Cities)
                .ThenInclude(c => c.Suburbs)
                .ThenInclude(s => s.Hospitals)
                .ToListAsync();
        }

        public override async Task<bool> DeleteAsync(object id)
        {
            var item = await context.Provinces.FindAsync(id);
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
