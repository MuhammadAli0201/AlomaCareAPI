using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync(string? includeProperties = null);
        Task<T?> GetAsync(object id, string? includeProperties = null);
        Task<T?> AddAsync(T entity);
        Task<T?> UpdateAsync(T entity);
        Task<bool> DeleteAsync(object id);
        Task<int> DeleteRangeAsync(IEnumerable<T> entities);
    }
}
