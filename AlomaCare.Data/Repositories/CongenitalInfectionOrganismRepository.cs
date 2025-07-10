using AlomaCare.Context;
using AlomaCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public class CongenitalInfectionOrganismRepository : Repository<CongenitalInfectionOrganism>, ICongenitalInfectionOrganism
    {
        public CongenitalInfectionOrganismRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
