using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlomaCare.Models.DTOs;

public class PatientCompleteInfoDTO
{
    public Guid Id { get; set; }

    [ForeignKey(nameof(Patient))]
    public Guid PatientId { get; set; }
    public Patient? Patient { get; set; }

    // NeonatalSepsis
    public string? NeonatalSepsis { get; set; }
    public Guid? CongenitalInfection { get; set; }
    public List<int>? CongenitalInfectionOrganism { get; set; }
    public string? SpecifyOther { get; set; }
    public Guid? BacterialSepsisBeforeDay3 { get; set; }
    public List<int>? BsOrganism { get; set; }
    public int? EarlyAntibiotics { get; set; }
    public Guid? SepsisAfterDay3 { get; set; }
    public List<Guid>? SepsisSite { get; set; }
    public Guid? BacterialPathogen { get; set; }
    public Guid? BacterialInfectionLocation { get; set; }
    public Guid? Cons { get; set; }
    public Guid? ConsLocation { get; set; }
    public string? OtherBacteria { get; set; }
    public Guid? FungalSepsis { get; set; }
    public Guid? BetaDGlucan { get; set; }
    public Guid? FungalSepsisLocation { get; set; }
    public List<int>? FungalOrganism { get; set; }
    public List<int>? LateSepsisAbx { get; set; }
    public string? SpecifyOtherAbx { get; set; }
    public string? AbxDuration { get; set; }

    // CRIBScore
    public Guid? AbgAvailable { get; set; }
    public string? BaseExcess { get; set; }
    public string? CribWeightGa { get; set; }
    public string? CribTemp { get; set; }
    public string? CribBaseExcess { get; set; }
    public string? CribTotal { get; set; }
    public Guid? EosCalcDone { get; set; }
    public string? EosRisk { get; set; }
    public Guid? EosRecommendation { get; set; }
    public Guid? EosFollowed { get; set; }

    // CranialUltrasoundInfo
    public Guid? CranialBefore28 { get; set; }
    public Guid? Ivh { get; set; }
    public Guid? WorstIvh { get; set; }
    public List<int>? SonarFindings { get; set; }
    public Guid? CysticPvl { get; set; }
    public string? OtherSonarFindings { get; set; }

    // RespiratoryComplications
    public List<Guid>? RespiratoryDiagnosis { get; set; }
    public Guid? PneumoLocation { get; set; }
    public List<Guid>? RespSupportAfter { get; set; }
    public Guid? HfncHighRate { get; set; }
    public string? HfStart { get; set; }
    public string? HfEnd { get; set; }
    public string? NcpapStart { get; set; }
    public string? NcpapEnd { get; set; }
    public string? NcpapDuration { get; set; }
    public string? Ncpap2Start { get; set; }
    public string? Ncpap2End { get; set; }
    public string? Ncpap2Duration { get; set; }
    public string? Vent1Start { get; set; }
    public string? Vent1End { get; set; }
    public string? Vent1Duration { get; set; }
    public string? Vent2Start { get; set; }
    public string? Vent2End { get; set; }
    public string? Vent2Duration { get; set; }
    public Guid? NcpapNoEtt { get; set; }
    public Guid? SeptalNecrosis { get; set; }
    public Guid? Ino { get; set; }
    public Guid? Oxygen28 { get; set; }
    public Guid? Resp28 { get; set; }
    public Guid? SteroidsCld { get; set; }
    public Guid? Caffeine { get; set; }
    public Guid? SurfactantInit { get; set; }
    public Guid? SurfactantAny { get; set; }
    public string? SvtDoses { get; set; }
    public string? SvtFirstHours { get; set; }
    public string? SvtFirstMinutes { get; set; }

    // OtherNeonatalComplication
    public string? Chd { get; set; }
    public Guid? PdaLiti { get; set; }
    public Guid? PdaIbuprofen { get; set; }
    public Guid? PdaParacetamol { get; set; }
    public Guid? InotropicSupport { get; set; }
    public Guid? HieSection { get; set; }
    public string? ThomsonScore { get; set; }
    public string? BloodGasResult { get; set; }
    public Guid? HieGradeSection { get; set; }
    public Guid? AeeG { get; set; }
    public List<Guid>? AeeGNotDoneReason { get; set; }
    public string? AeeGFindings { get; set; }
    public Guid? CerebralCooling { get; set; }
    public List<Guid>? CoolingNotDoneReason { get; set; }
    public List<Guid>? CoolingType { get; set; }
    public Guid? NecEnterocolitis { get; set; }
    public Guid? ParenteralNutrition { get; set; }
    public Guid? NecSurgery { get; set; }
    public Guid? OtherSurgery { get; set; }
    public List<Guid>? TypeNecSurgery { get; set; }
    public string? SurgeryCode1 { get; set; }
    public string? SurgeryCode2 { get; set; }
    public string? SurgeryCode3 { get; set; }
    public string? SurgeryCode4 { get; set; }
    public Guid? RetinopathyPre { get; set; }
    public List<Guid>? RopFindings { get; set; }
    public List<Guid>? RopSurgery { get; set; }
    public Guid? JaundiceRequirement { get; set; }
    public Guid? ExchangeTransfusion { get; set; }
    public string? MaxBilirubin { get; set; }
    public Guid? BloodTransfusion { get; set; }
    public Guid? PlateletTransfusion { get; set; }
    public Guid? PlasmaTransfusion { get; set; }
    public List<Guid>? MetabolicComplications { get; set; }
    public List<Guid>? GlucoseAbnormalities { get; set; }
    public Guid? MajorBirthDefect { get; set; }
    public string? DefectCodes { get; set; }
    public string? CongenitalAnomaly { get; set; }
    public Guid? KangarooCare { get; set; }

    // Outcome
    public List<Guid>? KmcType { get; set; }
    public List<Guid>? OutcomeSection { get; set; }
    public string? HospitalName { get; set; }
    public List<Guid>? FeedsOnDischarge { get; set; }
    public Guid? HomeOxygen { get; set; }
    public string? DischargeWeight { get; set; }
    public string? DurationOfStay { get; set; }
    public List<string> FileBase64List { get; set; }
}
