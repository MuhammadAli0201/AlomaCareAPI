using System.ComponentModel.DataAnnotations.Schema;

namespace AlomaCare.Models;

public class Maternal
{
    public Guid Id { get; set; } 
    public Guid PatientId { get; set; }
    public Patient? Patient { get; set; }     
    public DateTime CreatedAt { get; set; }
    public string HospitalNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int? age { get; set; }
    public string Parity { get; set; }
    public string Race { get; set; }
    public string Gravidity { get; set; } 
    public string AntenatalCare { get; set; }
    public string AntenatalSteroid { get; set; }
    public string AntenatalMgSulfate { get; set; }
    public string Chorioamnionitis { get; set; }
    public string Hypertension { get; set; }
    public string MaternalHiv { get; set; }
    public string HivProphylaxis { get; set; }
    public string HaartBegun { get; set; }
    public string Syphilis { get; set; }
    public string SyphilisTreated { get; set; }
    public string Diabetes { get; set; }
    public string Tb { get; set; }
    public string TbTreatment { get; set; }
    public string TeenageMother { get; set; }
    public string AbandonedBaby { get; set; }
    public string NeonatalAbstinence { get; set; }
    public string OtherInfo { get; set; }
    public string MultipleGestations { get; set; }
    public int? NumberOfBabies { get; set; }
}
