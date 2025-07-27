namespace AlomaCare.Models;

public class Outcome
{
    public Guid Id { get; set; }
    public List<Guid>? KmcType { get; set; }
    public List<Guid>? OutcomeSection { get; set; }
    public string? HospitalName { get; set; }
    public List<Guid>? FeedsOnDischarge { get; set; }
    public Guid? HomeOxygen { get; set; }
    public string? DischargeWeight { get; set; }
    public string? DurationOfStay { get; set; }
}
