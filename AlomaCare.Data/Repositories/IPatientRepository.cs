using AlomaCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Task<List<Patient>> GetPatientsFromStoredProcedure();
    }
}
