using AlomaCare.Context;
using AlomaCare.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Data.Repositories
{
    public class PatientCompleteInfoRepository : Repository<PatientCompleteInfo>, IPatientCompleteInfoRepository
    {
        private readonly AppDbContext context;

        public PatientCompleteInfoRepository(AppDbContext context): base(context)
        {
            this.context = context;
        }

        public async Task<PatientCompleteInfo?> GetByPatientId(Guid patientId)
        {
            var response = await context.PatientCompleteInfos
                .FirstOrDefaultAsync(p => p.PatientId == patientId);
            return response;
        }

        public override async Task<PatientCompleteInfo?> UpdateAsync(PatientCompleteInfo input)
        {
            var existing = await GetAsync(input.Id);
            if(existing != null)
            {
                existing.CongenitalInfectionOrganism = input.CongenitalInfectionOrganism;
                existing.BsOrganism = input.BsOrganism;
                existing.SepsisSite = input.SepsisSite;
                existing.FungalOrganism = input.FungalOrganism;
                existing.LateSepsisAbx = input.LateSepsisAbx;
                existing.SonarFindings = input.SonarFindings;
                existing.RespiratoryDiagnosis = input.RespiratoryDiagnosis;
                existing.RespSupportAfter = input.RespSupportAfter;
                existing.AeeGNotDoneReason = input.AeeGNotDoneReason;
                existing.CoolingNotDoneReason = input.CoolingNotDoneReason;
                existing.CoolingType = input.CoolingType;
                existing.TypeNecSurgery = input.TypeNecSurgery;
                existing.RopFindings = input.RopFindings;
                existing.RopSurgery = input.RopSurgery;
                existing.MetabolicComplications = input.MetabolicComplications;
                existing.GlucoseAbnormalities = input.GlucoseAbnormalities;
                existing.KmcType = input.KmcType;
                context.PatientCompleteInfos.Update(existing);
                await context.SaveChangesAsync();
                return existing;
            }
            return null;
        }
    }
}
