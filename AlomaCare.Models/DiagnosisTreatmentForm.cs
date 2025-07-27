namespace AlomaCare.Models;

public class DiagnosisTreatmentForm
{
    public Guid Id { get; set; }
    
    public Patient Patient { get; set; }
    public Guid PatientId { get; set; }

    public NeonatalSepsis NeonatalSepsis { get; set; }
    public Guid NeonatalSepsisId { get; set; }

    public CRIBScore CribScore { get; set; }
    public Guid CribScoreId { get; set; }

    public CranialUltrasoundInfo CranialUltrasoundInfo { get; set; }
    public Guid CranialUltrasoundInfoId { get; set; }

    public RespiratoryComplications RespiratoryComplications { get; set; }
    public Guid RespiratoryComplicationsId { get; set; }

    public OtherNeonatalComplication OtherNeonatalComplication { get; set; }
    public Guid OtherNeonatalComplicationId { get; set; }

    public Outcome Outcome { get; set; }
    public Guid OutcomeId { get; set; }
}
