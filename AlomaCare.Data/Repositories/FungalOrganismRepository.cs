using AlomaCare.Data.Repositories;
using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Repositories
{
    public class FungalOrganismRepository : Repository<FungalOrganism>, IFungalOrganismRepository
    {
        private readonly AppDbContext context;

        public FungalOrganismRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task<IEnumerable<FungalOrganism>> GetAsync(string? includeProperties = null)
        {
            return await context.FungalOrganisms.FromSqlRaw("EXEC [dbo].[GetAllFungalOrganisms]")
            .ToListAsync();
        }

        public override async Task<bool> DeleteAsync(object id)
        {
            var item = await context.FungalOrganisms.FindAsync(id);
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
