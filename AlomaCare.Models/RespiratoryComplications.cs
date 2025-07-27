namespace AlomaCare.Models;

public class RespiratoryComplications
{
    public Guid Id { get; set; }
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
}
