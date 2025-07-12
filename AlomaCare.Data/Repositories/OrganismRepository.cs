using AlomaCare.Context;
using AlomaCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public class OrganismRepository : Repository<Organism>, IOrganismRepository
    {
        public OrganismRepository(AppDbContext context):base(context)
        {   
        }
    }
}
