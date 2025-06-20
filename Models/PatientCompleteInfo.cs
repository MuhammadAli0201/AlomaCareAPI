using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlomaCareAPI.Models;

public class PatientCompleteInfo
{
    [Key]
    public Guid Id { get; set; }

    [ForeignKey(nameof(Patient))]
    public Guid PatientId { get; set; }
    public Patient Patient { get; set; }
    public string NeonatalSepsis { get; set; }
    public string CongenitalInfection { get; set; }
    public List<string> CongenitalInfectionOrganism { get; set; }
    public string SpecifyOther { get; set; }
    public string BacterialSepsisBeforeDay3 { get; set; }
    public List<string> BsOrganism { get; set; }
    public string EarlyAntibiotics { get; set; }
    public string SepsisAfterDay3 { get; set; }
    public List<string> SepsisSite { get; set; }
    public string BacterialPathogen { get; set; }
    public string BacterialInfectionLocation { get; set; }
    public string Cons { get; set; }
    public string ConsLocation { get; set; }
    public string OtherBacteria { get; set; }
    public string FungalSepsis { get; set; }
    public string BetaDGlucan { get; set; }
    public string FungalSepsisLocation { get; set; }
    public List<string> FungalOrganism { get; set; }
    public List<string> LateSepsisAbx { get; set; }
    public string SpecifyOtherAbx { get; set; }
    public string AbxDuration { get; set; }
    public string AbgAvailable { get; set; }
    public string BaseExcess { get; set; }
    public string CribWeightGa { get; set; }
    public string CribTemp { get; set; }
    public string CribBaseExcess { get; set; }
    public string CribTotal { get; set; }
    public string EosCalcDone { get; set; }
    public string EosRisk { get; set; }
    public string EosRecommendation { get; set; }
    public string EosFollowed { get; set; }
    public string CranialBefore28 { get; set; }
    public string Ivh { get; set; }
    public string WorstIvh { get; set; }
    public List<string> SonarFindings { get; set; }
    public string CysticPvl { get; set; }
    public string OtherSonarFindings { get; set; }
    public List<string> RespiratoryDiagnosis { get; set; }
    public string PneumoLocation { get; set; }
    public List<string> RespSupportAfter { get; set; }
    public string HfncHighRate { get; set; }
    public string HfStart { get; set; }
    public string HfEnd { get; set; }
    public string NcpapStart { get; set; }
    public string NcpapEnd { get; set; }
    public string NcpapDuration { get; set; }
    public string Ncpap2Start { get; set; }
    public string Ncpap2End { get; set; }
    public string Ncpap2Duration { get; set; }
    public string Vent1Start { get; set; }
    public string Vent1End { get; set; }
    public string Vent1Duration { get; set; }
    public string Vent2Start { get; set; }
    public string Vent2End { get; set; }
    public string Vent2Duration { get; set; }
    public string NcpapNoEtt { get; set; }
    public string SeptalNecrosis { get; set; }
    public string Ino { get; set; }
    public string Oxygen28 { get; set; }
    public string Resp28 { get; set; }
    public string SteroidsCld { get; set; }
    public string Caffeine { get; set; }
    public string SurfactantInit { get; set; }
    public string SurfactantAny { get; set; }
    public string SvtDoses { get; set; }
    public string SvtFirstHours { get; set; }
    public string SvtFirstMinutes { get; set; }
    public string Chd { get; set; }
    public string PdaLiti { get; set; }
    public string PdaIbuprofen { get; set; }
    public string PdaParacetamol { get; set; }
    public string InotropicSupport { get; set; }
    public string HieSection { get; set; }
    public string ThomsonScore { get; set; }
    public string BloodGasResult { get; set; }
    public string HieGradeSection { get; set; }
    public string AeeG { get; set; }
    public List<string> AeeGNotDoneReason { get; set; }
    public string AeeGFindings { get; set; }
    public string CerebralCooling { get; set; }
    public List<string> CoolingNotDoneReason { get; set; }
    public List<string> CoolingType { get; set; }
    public string NecEnterocolitis { get; set; }
    public string ParenteralNutrition { get; set; }
    public string NecSurgery { get; set; }
    public string OtherSurgery { get; set; }
    public List<string> TypeNecSurgery { get; set; }
    public string SurgeryCode1 { get; set; }
    public string SurgeryCode2 { get; set; }
    public string SurgeryCode3 { get; set; }
    public string SurgeryCode4 { get; set; }
    public string RetinopathyPre { get; set; }
    public List<string> RopFindings { get; set; }
    public List<string> RopSurgery { get; set; }
    public string JaundiceRequirement { get; set; }
    public string ExchangeTransfusion { get; set; }
    public string MaxBilirubin { get; set; }
    public string BloodTransfusion { get; set; }
    public string PlateletTransfusion { get; set; }
    public string PlasmaTransfusion { get; set; }
    public List<string> MetabolicComplications { get; set; }
    public List<string> GlucoseAbnormalities { get; set; }
    public string MajorBirthDefect { get; set; }
    public string DefectCodes { get; set; }
    public string CongenitalAnomaly { get; set; }
    public string KangarooCare { get; set; }
    public List<string> KmcType { get; set; }
    public List<string> OutcomeSection { get; set; }
    public string HospitalName { get; set; }
    public List<String> FeedsOnDischarge { get; set; }
    public string HomeOxygen{ get; set; }
    public string DischargeWeight { get; set; }
    public string DurationOfStay { get; set; }
}
