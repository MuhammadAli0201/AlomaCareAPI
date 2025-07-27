using AlomaCare.Models;
using AlomaCare.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public interface IDiagnosisTreatmentFormRepository : IRepository<DiagnosisTreatmentForm>
    {
        Task<PatientCompleteInfoDTO?> GetByPatientId(Guid patientId);
        Task<PatientCompleteInfoDTO?> UpdateAsync(PatientCompleteInfoDTO input);
        Task<PatientCompleteInfoDTO?> CreateAsync(PatientCompleteInfoDTO input);
    }
}
