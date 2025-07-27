using AlomaCare.Context;
using AlomaCare.Models;
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
