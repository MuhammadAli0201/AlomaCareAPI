using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlomaCareAPI.Models;

public class Patient
{
    public Guid Id { get; set; }
    public string HospitalNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime DateOfAdmission { get; set; }
    public int AgeOnAdmission { get; set; }
    public decimal BirthWeight { get; set; }
    public int? GestationalAge { get; set; }
    public string Gender { get; set; }
    public string PlaceOfBirth { get; set; }
    public string ModeOfDelivery { get; set; }
    public List<string> InitialResuscitation { get; set; }
    public List<string> ApgarTimes { get; set; }
    public string OutcomeStatus { get; set; }
    public string TransferHospital { get; set; }
    public string BirthHivPcr { get; set; }
    public decimal? HeadCircumference { get; set; }
    public decimal? FootLength { get; set; }
    public decimal? LengthAtBirth { get; set; }
    public bool DiedInDeliveryRoom { get; set; }
    public bool DiedWithin12Hours { get; set; }
    public decimal? InitialTemperature { get; set; }
    [ForeignKey(nameof(CreatedByUser))]
    public int CreatedByUserId { get; set; }
    public User CreatedByUser { get; set; }
    public Maternal Maternal { get; set; }
    public PatientCompleteInfo PatientCompleteInfo { get; set; }

}
