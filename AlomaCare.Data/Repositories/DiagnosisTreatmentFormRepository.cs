using AlomaCare.Context;
using AlomaCare.Models;
using AlomaCare.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AlomaCare.Data.Repositories
{
    public class DiagnosisTreatmentFormRepository : Repository<DiagnosisTreatmentForm>, IDiagnosisTreatmentFormRepository
    {
        private readonly AppDbContext context;

        public DiagnosisTreatmentFormRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<PatientCompleteInfoDTO?> GetByPatientId(Guid patientId)
        {
            var res = await context.DiagnosisTreatmentForms
                .Include(x => x.NeonatalSepsis)
                .Include(x => x.CribScore)
                .Include(x => x.CranialUltrasoundInfo)
                .Include(x => x.RespiratoryComplications)
                .Include(x => x.OtherNeonatalComplication)
                .Include(x => x.Outcome)
                .FirstOrDefaultAsync(p => p.PatientId == patientId);

            if (res is not null)
            {
                return this.MapDiagnosisTreatmentFormToPatientCompleteInfoDTO(res);
            }
            return null;
        }

        public async Task<PatientCompleteInfoDTO?> UpdateAsync(PatientCompleteInfoDTO dto)
        {
            // 1) load the full object graph
            var existing = await context.DiagnosisTreatmentForms
                .Include(x => x.NeonatalSepsis)
                .Include(x => x.CribScore)
                .Include(x => x.CranialUltrasoundInfo)
                .Include(x => x.RespiratoryComplications)
                .Include(x => x.OtherNeonatalComplication)
                .Include(x => x.Outcome)
                .FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (existing == null) return null;

            // 2) Map NeonatalSepsis
            existing.NeonatalSepsis.name = dto.NeonatalSepsis;
            existing.NeonatalSepsis.CongenitalInfectionId = (dto.CongenitalInfection);
            existing.NeonatalSepsis.CongenitalInfectionOrganism = dto.CongenitalInfectionOrganism;
            existing.NeonatalSepsis.SpecifyOther = dto.SpecifyOther;
            existing.NeonatalSepsis.BacterialSepsisBeforeDay3 = (dto.BacterialSepsisBeforeDay3);
            existing.NeonatalSepsis.BsOrganism = dto.BsOrganism;
            existing.NeonatalSepsis.EarlyAntibiotics = dto.EarlyAntibiotics ?? 0;
            existing.NeonatalSepsis.SepsisAfterDay3 = (dto.SepsisAfterDay3);
            existing.NeonatalSepsis.SepsisSite = (dto.SepsisSite);
            existing.NeonatalSepsis.BacterialPathogen = (dto.BacterialPathogen);
            existing.NeonatalSepsis.BacterialInfectionLocation = (dto.BacterialInfectionLocation);
            existing.NeonatalSepsis.Cons = (dto.Cons);
            existing.NeonatalSepsis.ConsLocation = (dto.ConsLocation);
            existing.NeonatalSepsis.OtherBacteria = dto.OtherBacteria;
            existing.NeonatalSepsis.FungalSepsis = (dto.FungalSepsis);
            existing.NeonatalSepsis.BetaDGlucan = (dto.BetaDGlucan);
            existing.NeonatalSepsis.FungalSepsisLocation = (dto.FungalSepsisLocation);
            existing.NeonatalSepsis.FungalOrganism = dto.FungalOrganism;
            existing.NeonatalSepsis.LateSepsisAbx = dto.LateSepsisAbx;
            existing.NeonatalSepsis.SpecifyOtherAbx = dto.SpecifyOtherAbx;
            existing.NeonatalSepsis.AbxDuration = dto.AbxDuration;

            // 3) Map CRIBScore
            existing.CribScore.AbgAvailable = (dto.AbgAvailable);
            existing.CribScore.BaseExcess = dto.BaseExcess;
            existing.CribScore.CribWeightGa = dto.CribWeightGa;
            existing.CribScore.CribTemp = dto.CribTemp;
            existing.CribScore.CribBaseExcess = dto.CribBaseExcess;
            existing.CribScore.CribTotal = dto.CribTotal;
            existing.CribScore.EosCalcDone = (dto.EosCalcDone);
            existing.CribScore.EosRisk = dto.EosRisk;
            existing.CribScore.EosRecommendation = (dto.EosRecommendation);
            existing.CribScore.EosFollowed = (dto.EosFollowed);

            // 4) Map CranialUltrasoundInfo
            existing.CranialUltrasoundInfo.CranialBefore28 = (dto.CranialBefore28);
            existing.CranialUltrasoundInfo.Ivh = (dto.Ivh);
            existing.CranialUltrasoundInfo.WorstIvh = (dto.WorstIvh);
            existing.CranialUltrasoundInfo.SonarFindings = dto.SonarFindings;
            existing.CranialUltrasoundInfo.CysticPvl = (dto.CysticPvl);
            existing.CranialUltrasoundInfo.OtherSonarFindings = dto.OtherSonarFindings;

            // 5) Map RespiratoryComplications
            existing.RespiratoryComplications.RespiratoryDiagnosis = dto.RespiratoryDiagnosis;
            existing.RespiratoryComplications.PneumoLocation = dto.PneumoLocation;
            existing.RespiratoryComplications.RespSupportAfter = (dto.RespSupportAfter);
            existing.RespiratoryComplications.HfncHighRate = (dto.HfncHighRate);
            existing.RespiratoryComplications.HfStart = dto.HfStart;
            existing.RespiratoryComplications.HfEnd = dto.HfEnd;
            existing.RespiratoryComplications.NcpapStart = dto.NcpapStart;
            existing.RespiratoryComplications.NcpapEnd = dto.NcpapEnd;
            existing.RespiratoryComplications.NcpapDuration = dto.NcpapDuration;
            existing.RespiratoryComplications.Ncpap2Start = dto.Ncpap2Start;
            existing.RespiratoryComplications.Ncpap2End = dto.Ncpap2End;
            existing.RespiratoryComplications.Ncpap2Duration = dto.Ncpap2Duration;
            existing.RespiratoryComplications.Vent1Start = dto.Vent1Start;
            existing.RespiratoryComplications.Vent1End = dto.Vent1End;
            existing.RespiratoryComplications.Vent1Duration = dto.Vent1Duration;
            existing.RespiratoryComplications.Vent2Start = dto.Vent2Start;
            existing.RespiratoryComplications.Vent2End = dto.Vent2End;
            existing.RespiratoryComplications.Vent2Duration = dto.Vent2Duration;
            existing.RespiratoryComplications.NcpapNoEtt = (dto.NcpapNoEtt);
            existing.RespiratoryComplications.SeptalNecrosis = (dto.SeptalNecrosis);
            existing.RespiratoryComplications.Ino = (dto.Ino);
            existing.RespiratoryComplications.Oxygen28 = (dto.Oxygen28);
            existing.RespiratoryComplications.Resp28 = (dto.Resp28);
            existing.RespiratoryComplications.SteroidsCld = (dto.SteroidsCld);
            existing.RespiratoryComplications.Caffeine = (dto.Caffeine);
            existing.RespiratoryComplications.SurfactantInit = (dto.SurfactantInit);
            existing.RespiratoryComplications.SurfactantAny = (dto.SurfactantAny);
            existing.RespiratoryComplications.SvtDoses = dto.SvtDoses;
            existing.RespiratoryComplications.SvtFirstHours = dto.SvtFirstHours;
            existing.RespiratoryComplications.SvtFirstMinutes = dto.SvtFirstMinutes;

            // 6) Map OtherNeonatalComplication
            var other = existing.OtherNeonatalComplication;
            other.Chd = dto.Chd;
            other.PdaLiti = (dto.PdaLiti);
            other.PdaIbuprofen = (dto.PdaIbuprofen);
            other.PdaParacetamol = (dto.PdaParacetamol);
            other.InotropicSupport = (dto.InotropicSupport);
            other.HieSection = (dto.HieSection);
            other.ThomsonScore = dto.ThomsonScore;
            other.BloodGasResult = dto.BloodGasResult;
            other.HieGradeSection = (dto.HieGradeSection);
            other.AeeG = (dto.AeeG);
            other.AeeGNotDoneReason = (dto.AeeGNotDoneReason);
            other.AeeGFindings = dto.AeeGFindings;
            other.CerebralCooling = (dto.CerebralCooling);
            other.CoolingNotDoneReason = (dto.CoolingNotDoneReason);
            other.CoolingType = (dto.CoolingType);
            other.NecEnterocolitis = (dto.NecEnterocolitis);
            other.ParenteralNutrition = (dto.ParenteralNutrition);
            other.NecSurgery = (dto.NecSurgery);
            other.OtherSurgery = (dto.OtherSurgery);
            other.TypeNecSurgery = (dto.TypeNecSurgery);
            other.SurgeryCode1 = dto.SurgeryCode1;
            other.SurgeryCode2 = dto.SurgeryCode2;
            other.SurgeryCode3 = dto.SurgeryCode3;
            other.SurgeryCode4 = dto.SurgeryCode4;
            other.RetinopathyPre = (dto.RetinopathyPre);
            other.RopFindings = (dto.RopFindings);
            other.RopSurgery = (dto.RopSurgery);
            other.JaundiceRequirement = (dto.JaundiceRequirement);
            other.ExchangeTransfusion = (dto.ExchangeTransfusion);
            other.MaxBilirubin = dto.MaxBilirubin;
            other.BloodTransfusion = (dto.BloodTransfusion);
            other.PlateletTransfusion = (dto.PlateletTransfusion);
            other.PlasmaTransfusion = (dto.PlasmaTransfusion);
            other.MetabolicComplications = (dto.MetabolicComplications);
            other.GlucoseAbnormalities = (dto.GlucoseAbnormalities);
            other.MajorBirthDefect = (dto.MajorBirthDefect);
            other.DefectCodes = dto.DefectCodes;
            other.CongenitalAnomaly = dto.CongenitalAnomaly;
            other.KangarooCare = (dto.KangarooCare);

            var outc = existing.Outcome;
            outc.KmcType = (dto.KmcType);
            outc.OutcomeSection = (dto.OutcomeSection);
            outc.HospitalName = dto.HospitalName;
            outc.FeedsOnDischarge = (dto.FeedsOnDischarge);
            outc.HomeOxygen = (dto.HomeOxygen);
            outc.DischargeWeight = dto.DischargeWeight;
            outc.DurationOfStay = dto.DurationOfStay;

            // 8) Mark entity as modified & save
            context.Update(existing);
            await context.SaveChangesAsync();

            return dto;
        }

        public async Task<PatientCompleteInfoDTO?> CreateAsync(PatientCompleteInfoDTO input)
        {
            var form = new DiagnosisTreatmentForm
            {
                Id = input.Id == Guid.Empty ? Guid.NewGuid() : input.Id,
                PatientId = input.PatientId,
                NeonatalSepsis = new NeonatalSepsis
                {
                    Id = input.CongenitalInfection ?? Guid.NewGuid(), // placeholder mapping
                    name = input.NeonatalSepsis,
                    CongenitalInfectionId = input.CongenitalInfection,
                    CongenitalInfectionOrganism = input.CongenitalInfectionOrganism,
                    SpecifyOther = input.SpecifyOther,
                    BacterialSepsisBeforeDay3 = input.BacterialSepsisBeforeDay3,
                    BsOrganism = input.BsOrganism,
                    EarlyAntibiotics = input.EarlyAntibiotics,
                    SepsisAfterDay3 = input.SepsisAfterDay3,
                    SepsisSite = input.SepsisSite,
                    BacterialPathogen = input.BacterialPathogen,
                    BacterialInfectionLocation = input.BacterialInfectionLocation,
                    Cons = input.Cons,
                    ConsLocation = input.ConsLocation,
                    OtherBacteria = input.OtherBacteria,
                    FungalSepsis = input.FungalSepsis,
                    BetaDGlucan = input.BetaDGlucan,
                    FungalSepsisLocation = input.FungalSepsisLocation,
                    FungalOrganism = input.FungalOrganism,
                    LateSepsisAbx = input.LateSepsisAbx,
                    SpecifyOtherAbx = input.SpecifyOtherAbx,
                    AbxDuration = input.AbxDuration
                },
                CribScore = new CRIBScore
                {
                    Id = Guid.NewGuid(),
                    AbgAvailable = input.AbgAvailable,
                    BaseExcess = input.BaseExcess,
                    CribWeightGa = input.CribWeightGa,
                    CribTemp = input.CribTemp,
                    CribBaseExcess = input.CribBaseExcess,
                    CribTotal = input.CribTotal,
                    EosCalcDone = input.EosCalcDone,
                    EosRisk = input.EosRisk,
                    EosRecommendation = input.EosRecommendation,
                    EosFollowed = input.EosFollowed
                },
                CranialUltrasoundInfo = new CranialUltrasoundInfo
                {
                    Id = Guid.NewGuid(),
                    CranialBefore28 = input.CranialBefore28,
                    Ivh = input.Ivh,
                    WorstIvh = input.WorstIvh,
                    SonarFindings = input.SonarFindings,
                    CysticPvl = input.CysticPvl,
                    OtherSonarFindings = input.OtherSonarFindings
                },
                RespiratoryComplications = new RespiratoryComplications
                {
                    Id = Guid.NewGuid(),
                    RespiratoryDiagnosis = input.RespiratoryDiagnosis,
                    PneumoLocation = input.PneumoLocation,
                    RespSupportAfter = input.RespSupportAfter,
                    HfncHighRate = input.HfncHighRate,
                    HfStart = input.HfStart,
                    HfEnd = input.HfEnd,
                    NcpapStart = input.NcpapStart,
                    NcpapEnd = input.NcpapEnd,
                    NcpapDuration = input.NcpapDuration,
                    Ncpap2Start = input.Ncpap2Start,
                    Ncpap2End = input.Ncpap2End,
                    Ncpap2Duration = input.Ncpap2Duration,
                    Vent1Start = input.Vent1Start,
                    Vent1End = input.Vent1End,
                    Vent1Duration = input.Vent1Duration,
                    Vent2Start = input.Vent2Start,
                    Vent2End = input.Vent2End,
                    Vent2Duration = input.Vent2Duration,
                    NcpapNoEtt = input.NcpapNoEtt,
                    SeptalNecrosis = input.SeptalNecrosis,
                    Ino = input.Ino,
                    Oxygen28 = input.Oxygen28,
                    Resp28 = input.Resp28,
                    SteroidsCld = input.SteroidsCld,
                    Caffeine = input.Caffeine,
                    SurfactantInit = input.SurfactantInit,
                    SurfactantAny = input.SurfactantAny,
                    SvtDoses = input.SvtDoses,
                    SvtFirstHours = input.SvtFirstHours,
                    SvtFirstMinutes = input.SvtFirstMinutes
                },
                OtherNeonatalComplication = new OtherNeonatalComplication
                {
                    Id = Guid.NewGuid(),
                    Chd = input.Chd,
                    PdaLiti = input.PdaLiti,
                    PdaIbuprofen = input.PdaIbuprofen,
                    PdaParacetamol = input.PdaParacetamol,
                    InotropicSupport = input.InotropicSupport,
                    HieSection = input.HieSection,
                    ThomsonScore = input.ThomsonScore,
                    BloodGasResult = input.BloodGasResult,
                    HieGradeSection = input.HieGradeSection,
                    AeeG = input.AeeG,
                    AeeGNotDoneReason = input.AeeGNotDoneReason,
                    AeeGFindings = input.AeeGFindings,
                    CerebralCooling = input.CerebralCooling,
                    CoolingNotDoneReason = input.CoolingNotDoneReason,
                    CoolingType = input.CoolingType,
                    NecEnterocolitis = input.NecEnterocolitis,
                    ParenteralNutrition = input.ParenteralNutrition,
                    NecSurgery = input.NecSurgery,
                    OtherSurgery = input.OtherSurgery,
                    TypeNecSurgery = input.TypeNecSurgery,
                    SurgeryCode1 = input.SurgeryCode1,
                    SurgeryCode2 = input.SurgeryCode2,
                    SurgeryCode3 = input.SurgeryCode3,
                    SurgeryCode4 = input.SurgeryCode4,
                    RetinopathyPre = input.RetinopathyPre,
                    RopFindings = input.RopFindings,
                    RopSurgery = input.RopSurgery,
                    JaundiceRequirement = input.JaundiceRequirement,
                    ExchangeTransfusion = input.ExchangeTransfusion,
                    MaxBilirubin = input.MaxBilirubin,
                    BloodTransfusion = input.BloodTransfusion,
                    PlateletTransfusion = input.PlateletTransfusion,
                    PlasmaTransfusion = input.PlasmaTransfusion,
                    MetabolicComplications = input.MetabolicComplications,
                    GlucoseAbnormalities = input.GlucoseAbnormalities,
                    MajorBirthDefect = input.MajorBirthDefect,
                    DefectCodes = input.DefectCodes,
                    CongenitalAnomaly = input.CongenitalAnomaly,
                    KangarooCare = input.KangarooCare
                },
                Outcome = new Outcome
                {
                    Id = Guid.NewGuid(),
                    KmcType = input.KmcType,
                    OutcomeSection = input.OutcomeSection,
                    HospitalName = input.HospitalName,
                    FeedsOnDischarge = input.FeedsOnDischarge,
                    HomeOxygen = input.HomeOxygen,
                    DischargeWeight = input.DischargeWeight,
                    DurationOfStay = input.DurationOfStay
                }
            };

            // Set foreign keys
            form.NeonatalSepsisId = form.NeonatalSepsis.Id;
            form.CribScoreId = form.CribScore.Id;
            form.CranialUltrasoundInfoId = form.CranialUltrasoundInfo.Id;
            form.RespiratoryComplicationsId = form.RespiratoryComplications.Id;
            form.OtherNeonatalComplicationId = form.OtherNeonatalComplication.Id;
            form.OutcomeId = form.Outcome.Id;

            // Save the whole graph
            context.DiagnosisTreatmentForms.Add(form);
            await context.SaveChangesAsync();

            return input;
        }

        private PatientCompleteInfoDTO MapDiagnosisTreatmentFormToPatientCompleteInfoDTO(DiagnosisTreatmentForm form)
        {
            return new PatientCompleteInfoDTO
            {
                Id = form.Id,
                PatientId = form.PatientId,
                Patient = form.Patient,

                // NeonatalSepsis
                NeonatalSepsis = form.NeonatalSepsis?.name,
                CongenitalInfection = form.NeonatalSepsis?.CongenitalInfectionId,
                CongenitalInfectionOrganism = form.NeonatalSepsis?.CongenitalInfectionOrganism,
                SpecifyOther = form.NeonatalSepsis?.SpecifyOther,
                BacterialSepsisBeforeDay3 = form.NeonatalSepsis?.BacterialSepsisBeforeDay3,
                BsOrganism = form.NeonatalSepsis?.BsOrganism,
                EarlyAntibiotics = form.NeonatalSepsis?.EarlyAntibiotics,
                SepsisAfterDay3 = form.NeonatalSepsis?.SepsisAfterDay3,
                SepsisSite = form.NeonatalSepsis?.SepsisSite,
                BacterialPathogen = form.NeonatalSepsis?.BacterialPathogen,
                BacterialInfectionLocation = form.NeonatalSepsis?.BacterialInfectionLocation,
                Cons = form.NeonatalSepsis?.Cons,
                ConsLocation = form.NeonatalSepsis?.ConsLocation,
                OtherBacteria = form.NeonatalSepsis?.OtherBacteria,
                FungalSepsis = form.NeonatalSepsis?.FungalSepsis,
                BetaDGlucan = form.NeonatalSepsis?.BetaDGlucan,
                FungalSepsisLocation = form.NeonatalSepsis?.FungalSepsisLocation,
                FungalOrganism = form.NeonatalSepsis?.FungalOrganism,
                LateSepsisAbx = form.NeonatalSepsis?.LateSepsisAbx,
                SpecifyOtherAbx = form.NeonatalSepsis?.SpecifyOtherAbx,
                AbxDuration = form.NeonatalSepsis?.AbxDuration,

                // CRIBScore
                AbgAvailable = form.CribScore?.AbgAvailable,
                BaseExcess = form.CribScore?.BaseExcess,
                CribWeightGa = form.CribScore?.CribWeightGa,
                CribTemp = form.CribScore?.CribTemp,
                CribBaseExcess = form.CribScore?.CribBaseExcess,
                CribTotal = form.CribScore?.CribTotal,
                EosCalcDone = form.CribScore?.EosCalcDone,
                EosRisk = form.CribScore?.EosRisk,
                EosRecommendation = form.CribScore?.EosRecommendation,
                EosFollowed = form.CribScore?.EosFollowed,

                // CranialUltrasoundInfo
                CranialBefore28 = form.CranialUltrasoundInfo?.CranialBefore28,
                Ivh = form.CranialUltrasoundInfo?.Ivh,
                WorstIvh = form.CranialUltrasoundInfo?.WorstIvh,
                SonarFindings = form.CranialUltrasoundInfo?.SonarFindings,
                CysticPvl = form.CranialUltrasoundInfo?.CysticPvl,
                OtherSonarFindings = form.CranialUltrasoundInfo?.OtherSonarFindings,

                // RespiratoryComplications
                RespiratoryDiagnosis = form.RespiratoryComplications?.RespiratoryDiagnosis,
                PneumoLocation = form.RespiratoryComplications?.PneumoLocation,
                RespSupportAfter = form.RespiratoryComplications?.RespSupportAfter,
                HfncHighRate = form.RespiratoryComplications?.HfncHighRate,
                HfStart = form.RespiratoryComplications?.HfStart,
                HfEnd = form.RespiratoryComplications?.HfEnd,
                NcpapStart = form.RespiratoryComplications?.NcpapStart,
                NcpapEnd = form.RespiratoryComplications?.NcpapEnd,
                NcpapDuration = form.RespiratoryComplications?.NcpapDuration,
                Ncpap2Start = form.RespiratoryComplications?.Ncpap2Start,
                Ncpap2End = form.RespiratoryComplications?.Ncpap2End,
                Ncpap2Duration = form.RespiratoryComplications?.Ncpap2Duration,
                Vent1Start = form.RespiratoryComplications?.Vent1Start,
                Vent1End = form.RespiratoryComplications?.Vent1End,
                Vent1Duration = form.RespiratoryComplications?.Vent1Duration,
                Vent2Start = form.RespiratoryComplications?.Vent2Start,
                Vent2End = form.RespiratoryComplications?.Vent2End,
                Vent2Duration = form.RespiratoryComplications?.Vent2Duration,
                NcpapNoEtt = form.RespiratoryComplications?.NcpapNoEtt,
                SeptalNecrosis = form.RespiratoryComplications?.SeptalNecrosis,
                Ino = form.RespiratoryComplications?.Ino,
                Oxygen28 = form.RespiratoryComplications?.Oxygen28,
                Resp28 = form.RespiratoryComplications?.Resp28,
                SteroidsCld = form.RespiratoryComplications?.SteroidsCld,
                Caffeine = form.RespiratoryComplications?.Caffeine,
                SurfactantInit = form.RespiratoryComplications?.SurfactantInit,
                SurfactantAny = form.RespiratoryComplications?.SurfactantAny,
                SvtDoses = form.RespiratoryComplications?.SvtDoses,
                SvtFirstHours = form.RespiratoryComplications?.SvtFirstHours,
                SvtFirstMinutes = form.RespiratoryComplications?.SvtFirstMinutes,

                // OtherNeonatalComplication
                Chd = form.OtherNeonatalComplication?.Chd,
                PdaLiti = form.OtherNeonatalComplication?.PdaLiti,
                PdaIbuprofen = form.OtherNeonatalComplication?.PdaIbuprofen,
                PdaParacetamol = form.OtherNeonatalComplication?.PdaParacetamol,
                InotropicSupport = form.OtherNeonatalComplication?.InotropicSupport,
                HieSection = form.OtherNeonatalComplication?.HieSection,
                ThomsonScore = form.OtherNeonatalComplication?.ThomsonScore,
                BloodGasResult = form.OtherNeonatalComplication?.BloodGasResult,
                HieGradeSection = form.OtherNeonatalComplication?.HieGradeSection,
                AeeG = form.OtherNeonatalComplication?.AeeG,
                AeeGNotDoneReason = form.OtherNeonatalComplication?.AeeGNotDoneReason,
                AeeGFindings = form.OtherNeonatalComplication?.AeeGFindings,
                CerebralCooling = form.OtherNeonatalComplication?.CerebralCooling,
                CoolingNotDoneReason = form.OtherNeonatalComplication?.CoolingNotDoneReason,
                CoolingType = form.OtherNeonatalComplication?.CoolingType,
                NecEnterocolitis = form.OtherNeonatalComplication?.NecEnterocolitis,
                ParenteralNutrition = form.OtherNeonatalComplication?.ParenteralNutrition,
                NecSurgery = form.OtherNeonatalComplication?.NecSurgery,
                OtherSurgery = form.OtherNeonatalComplication?.OtherSurgery,
                TypeNecSurgery = form.OtherNeonatalComplication?.TypeNecSurgery,
                SurgeryCode1 = form.OtherNeonatalComplication?.SurgeryCode1,
                SurgeryCode2 = form.OtherNeonatalComplication?.SurgeryCode2,
                SurgeryCode3 = form.OtherNeonatalComplication?.SurgeryCode3,
                SurgeryCode4 = form.OtherNeonatalComplication?.SurgeryCode4,
                RetinopathyPre = form.OtherNeonatalComplication?.RetinopathyPre,
                RopFindings = form.OtherNeonatalComplication?.RopFindings,
                RopSurgery = form.OtherNeonatalComplication?.RopSurgery,
                JaundiceRequirement = form.OtherNeonatalComplication?.JaundiceRequirement,
                ExchangeTransfusion = form.OtherNeonatalComplication?.ExchangeTransfusion,
                MaxBilirubin = form.OtherNeonatalComplication?.MaxBilirubin,
                BloodTransfusion = form.OtherNeonatalComplication?.BloodTransfusion,
                PlateletTransfusion = form.OtherNeonatalComplication?.PlateletTransfusion,
                PlasmaTransfusion = form.OtherNeonatalComplication?.PlasmaTransfusion,
                MetabolicComplications = form.OtherNeonatalComplication?.MetabolicComplications,
                GlucoseAbnormalities = form.OtherNeonatalComplication?.GlucoseAbnormalities,
                MajorBirthDefect = form.OtherNeonatalComplication?.MajorBirthDefect,
                DefectCodes = form.OtherNeonatalComplication?.DefectCodes,
                CongenitalAnomaly = form.OtherNeonatalComplication?.CongenitalAnomaly,
                KangarooCare = form.OtherNeonatalComplication?.KangarooCare,

                // Outcome
                KmcType = form.Outcome?.KmcType,
                OutcomeSection = form.Outcome?.OutcomeSection,
                HospitalName = form.Outcome?.HospitalName,
                FeedsOnDischarge = form.Outcome?.FeedsOnDischarge,
                HomeOxygen = form.Outcome?.HomeOxygen,
                DischargeWeight = form.Outcome?.DischargeWeight,
                DurationOfStay = form.Outcome?.DurationOfStay
            };
        }
    }
}

