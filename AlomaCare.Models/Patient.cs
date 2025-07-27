using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AlomaCare.Models.DTOs;

namespace AlomaCare.Models;

public class Patient
{
    public Guid Id { get; set; }
    public string HospitalNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime DateOfAdmission { get; set; }
    public int? AgeOnAdmission { get; set; }
    public decimal? BirthWeight { get; set; }
    public string? GestationalUnit { get; set; }
    public int? GestationalAge { get; set; }
    public string Gender { get; set; }
    public string PlaceOfBirth { get; set; }
    [ForeignKey(nameof(Province))]
    public int ProvinceId { get; set; }
    public Province? Province { get; set; }
    [ForeignKey(nameof(City))]
    public int CityId { get; set; }
    public City? City { get; set; }
    [ForeignKey(nameof(Suburb))]
    public int SuburbId { get; set; }
    public Suburb? Suburb{ get; set; }
    [ForeignKey(nameof(Hospital))]
    public int HospitalId { get; set; }
    public Hospital? Hospital { get; set; }
    public string ModeOfDelivery { get; set; }
    public List<string> InitialResuscitation { get; set; }
    public string OneMinuteApgar { get; set; }
    public string FiveMinuteApgar { get; set; }
    public string TenMinuteApgar { get; set; }
    public string OutcomeStatus { get; set; }
    public string TransferHospital { get; set; }
    public string BirthHivPcr { get; set; }
    public decimal? HeadCircumference { get; set; }
    public decimal? FootLength { get; set; }
    public decimal? LengthAtBirth { get; set; }
    public bool DiedInDeliveryRoom { get; set; }
    public bool DiedWithin12Hours { get; set; }
    public decimal? InitialTemperature { get; set; }
    public string MothersGtNumber { get; set; }
    public DateTime? DateOfDeath { get; set; }
    public string ConditionAtBirth { get; set; }
    public string SyphilisSerology { get; set; }
    public string SingleOrMultipleBirths { get; set; }
    public string ObstetricCauseOfDeath { get; set; }
    public string NeonatalCauseOfDeath { get; set; }
    public string AvoidableFactors { get; set; }
    [ForeignKey(nameof(CreatedByUser))]
    public int CreatedByUserId { get; set; }
    public User? CreatedByUser { get; set; }
    public Maternal? Maternal { get; set; }
    public PatientCompleteInfoDTO? PatientCompleteInfo { get; set; }

}
