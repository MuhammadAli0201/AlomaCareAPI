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
    public class HelpResourceRepository : Repository<HelpResource>, IHelpResourceRepository
    {
        private readonly AppDbContext context;

        public HelpResourceRepository(AppDbContext context):base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<HelpResource>> GetByType(string type)
        {
            var response = await context.HelpResources.Where(h => h.Type == type).ToListAsync();
            return response;
        }
    }
}
