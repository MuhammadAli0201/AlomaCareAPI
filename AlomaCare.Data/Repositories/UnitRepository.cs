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
    public class UnitRepository : Repository<Unit>, IUnitRepository
    {
        private readonly AppDbContext context;

        public UnitRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task<IEnumerable<Unit>> GetAsync(string? includeProperties = null)
        {
            return await context.Units.FromSqlRaw("EXEC [dbo].[GetAllUnits]")
                .ToListAsync();
        }

        public override async Task<bool> DeleteAsync(object id)
        {
            var item = await context.Units.FindAsync(id);
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
