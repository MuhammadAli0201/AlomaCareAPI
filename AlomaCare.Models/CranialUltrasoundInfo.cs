namespace AlomaCare.Models;

public class CranialUltrasoundInfo
{
    public Guid Id { get; set; }
    public Guid? CranialBefore28 { get; set; }
    public Guid? Ivh { get; set; }
    public Guid? WorstIvh { get; set; }
    public List<int>? SonarFindings { get; set; }
    public Guid? CysticPvl { get; set; }
    public string? OtherSonarFindings { get; set; }
}
