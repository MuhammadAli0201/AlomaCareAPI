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
    public class OrganismRepository : Repository<Organism>, IOrganismRepository
    {
        private readonly AppDbContext context;

        public OrganismRepository(AppDbContext context):base(context)
        {
            this.context = context;
        }

        public override async Task<IEnumerable<Organism>> GetAsync(string? includeProperties = null)
        {
            return await context.Organisms.FromSqlRaw("EXEC [dbo].[GetAllOrganisms]")
            .ToListAsync();
        }

        public override async Task<Organism?> GetAsync(object id, string? includeProperties = null)
        {
            return await context.Organisms.FindAsync(id);
        }

        public override async Task<bool> DeleteAsync(object id)
        {
            var item = await context.Organisms.FindAsync(id);
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
