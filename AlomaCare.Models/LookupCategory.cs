namespace AlomaCare.Models;

public class LookupCategory
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<LookupItem> LookupItems { get; set; }
}
