using AlomaCare.Context;
using AlomaCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public class AntimicrobialRepository : Repository<Antimicrobial>, IAntimicrobialRepository
    {
        public AntimicrobialRepository(AppDbContext context) : base(context) {}
    }
}
