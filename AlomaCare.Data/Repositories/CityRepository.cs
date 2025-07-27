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
    public class CityRepository : Repository<City>, ICityRepository
    {
        private readonly AppDbContext context;

        public CityRepository(AppDbContext context): base(context)
        {
            this.context = context;
        }

        public async Task<List<City>> GetByProvinceIdAsync(int provinceId)
        {
            return await context.Cities.Where(c => c.ProvinceId == provinceId).ToListAsync();
        }

        public override async Task<IEnumerable<City>> GetAsync(string? includeProperties = null)
        {
            return await context.Cities.FromSqlRaw("EXEC [dbo].[GetAllCities]")
                .ToListAsync();
        }

        public override async Task<bool> DeleteAsync(object id)
        {
            var item = await context.Cities.FindAsync(id);
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
