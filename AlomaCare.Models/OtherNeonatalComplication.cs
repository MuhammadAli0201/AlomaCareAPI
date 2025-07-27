namespace AlomaCare.Models;

public class OtherNeonatalComplication
{
    public Guid Id { get; set; }
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
}
