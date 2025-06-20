using AlomaCareAPI.Context;
using AlomaCareAPI.Models;
using AlomaCareAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AlomaCareAPI.Repositories
{
    public class FungalOrganismRepository : IFungalOrganismRepository
    {
        private readonly AppDbContext _context;

        public FungalOrganismRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FungalOrganism>> GetAllAsync()
        {
            return await _context.FungalOrganisms.ToListAsync();
        }

        public async Task<FungalOrganism> GetByIdAsync(int id)
        {
            return await _context.FungalOrganisms.FindAsync(id);
        }

        public async Task AddAsync(FungalOrganism fungalOrganism)
        {
            await _context.FungalOrganisms.AddAsync(fungalOrganism);
        }

        public void Update(FungalOrganism fungalOrganism)
        {
            _context.Entry(fungalOrganism).State = EntityState.Modified;
        }

        public void Delete(FungalOrganism fungalOrganism)
        {
            _context.FungalOrganisms.Remove(fungalOrganism);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }

}
