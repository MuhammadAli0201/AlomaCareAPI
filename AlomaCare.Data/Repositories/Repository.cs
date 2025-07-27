using AlomaCare.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext db;
        internal DbSet<T> dbSet;

        public Repository(AppDbContext db)
        {
            this.db = db;
            dbSet = db.Set<T>();
        }

        virtual public async Task<IEnumerable<T>> GetAsync(string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                query = GetQueryableWithProperties(query, includeProperties);
            }
            var result = await query.ToListAsync();
            return result;
        }

        public virtual async Task<T?> GetAsync(object id, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                query = GetQueryableWithProperties(query, includeProperties);
            }
            T? entity = await query.FirstOrDefaultAsync(o => EF.Property<object>(o, "Id").Equals(id));
            return entity;
        }

        public async Task<T?> AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            int rowsAffected = await db.SaveChangesAsync();
            return rowsAffected > 0 ? entity : null;
        }

        public virtual async Task<T?> UpdateAsync(T entity)
        {
            dbSet.Update(entity);
            int rowsAffected = await db.SaveChangesAsync();
            return rowsAffected > 0 ? entity : null;
        }

        virtual public async Task<bool> DeleteAsync(object id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity is not null)
            {
                dbSet.Remove(entity);
            }
            int rowsAffected = await db.SaveChangesAsync();
            return rowsAffected > 0;
        }

        public async Task<int> DeleteRangeAsync(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
            int rowsAffected = await db.SaveChangesAsync();
            return rowsAffected;
        }

        private IQueryable<T> GetQueryableWithProperties(IQueryable<T> query, string includeProperties)
        {
            foreach (var property in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(property);
            }
            return query;
        }
    }
}
