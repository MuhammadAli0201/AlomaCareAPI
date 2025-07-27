using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Data.Repositories;

public class LookupRepository(AppDbContext context) : IlookupRepository
{
    public async Task<List<LookupItem>> GetByCategoryId(Guid id)
    {
        var items = context.lookupItems.Where(x => x.CategoryId == id);
        return await items.ToListAsync();
    }
}
