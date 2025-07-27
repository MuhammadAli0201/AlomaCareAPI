using AlomaCare.Models;

namespace AlomaCare.Data.Repositories;

public interface IlookupRepository
{
    Task<List<LookupItem>> GetByCategoryId(Guid id);
}
