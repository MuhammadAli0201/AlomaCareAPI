using AlomaCare.Data.Repositories;
using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Repositories
{
    public class FungalOrganismRepository : Repository<FungalOrganism>, IFungalOrganismRepository
    {
        public FungalOrganismRepository(AppDbContext context) : base(context){}
    }

}
