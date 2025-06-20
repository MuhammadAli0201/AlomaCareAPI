using AlomaCareAPI.Models;

namespace AlomaCareAPI.Repositories.Interfaces
{
    public interface IFungalOrganismRepository
    {
        Task<IEnumerable<FungalOrganism>> GetAllAsync();
        Task<FungalOrganism> GetByIdAsync(int id);
        Task AddAsync(FungalOrganism fungalOrganism);
        void Update(FungalOrganism fungalOrganism);
        void Delete(FungalOrganism fungalOrganism);
        Task SaveChangesAsync();
    }
}
