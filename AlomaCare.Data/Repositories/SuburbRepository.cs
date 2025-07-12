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
    public class SuburbRepository : Repository<Suburb>, ISuburbRepository
    {
        private readonly AppDbContext context;

        public SuburbRepository(AppDbContext context): base(context)
        {
            this.context = context;
        }

        public async Task<List<Suburb>> GetByCityIdAsync(int cityId)
        {
            return await context.Suburbs.Where(s => s.CityId == cityId).ToListAsync();
        }
    }
}
