namespace AlomaCare.Models;

public class NeonatalSepsis
{
    public Guid Id { get; set; }
    public string? name { get; set; }
    public Guid? CongenitalInfectionId { get; set; }
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
}
