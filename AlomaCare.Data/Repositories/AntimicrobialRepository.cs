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
    public class AntimicrobialRepository : Repository<Antimicrobial>, IAntimicrobialRepository
    {
        private readonly AppDbContext context;

        public AntimicrobialRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task<IEnumerable<Antimicrobial>> GetAsync(string? includeProperties = null)
        {
            return await context.Antimicrobials.FromSqlRaw("EXEC [dbo].[GetAllFungalAntimicrobials]")
                .ToListAsync();
        }

        public override async Task<Antimicrobial?> GetAsync(object id, string? includeProperties = null)
        {
            return await context.Antimicrobials.FindAsync(id);
        }

        public override async Task<bool> DeleteAsync(object id)
        {
            var item = await context.Antimicrobials.FindAsync(id);
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
