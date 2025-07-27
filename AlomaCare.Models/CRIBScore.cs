namespace AlomaCare.Models;

public class CRIBScore
{
    public Guid Id { get; set; }
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
}
