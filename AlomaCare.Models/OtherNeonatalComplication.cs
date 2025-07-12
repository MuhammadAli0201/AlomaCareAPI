using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class OtherNeonatalComplication
    {
        [Key]
        public int OtherNeonatalComplicationId { get; set; }

        public string? CHD { get; set; }

        [ForeignKey(nameof(PDALitigationOption))]
        public int? PDALitigationOptionId { get; set; }
        public PDALitigationOption? PDALitigationOption { get; set; }

        [ForeignKey(nameof(IbuprofenForPDAOption))]
        public int? IbuprofenForPDAOptionId { get; set; }
        public IbuprofenForPDAOption? IbuprofenForPDAOption { get; set; }

        [ForeignKey(nameof(ParacetamolForPDAOption))]
        public int? ParacetamolForPDAOptionId { get; set; }
        public ParacetamolForPDAOption? ParacetamolForPDAOption { get; set; }

        [ForeignKey(nameof(IntropicSupportOption))]
        public int? InotropicSupportOptionId { get; set; }
        public IntropicSupportOption? IntropicSupportOption { get; set; }

        public bool? HIE { get; set; }

        public string? ThomsonScore { get; set; }
        public string? BloodGasResult { get; set; }

        [ForeignKey(nameof(HIEOption))]
        public int? HIEOptionId { get; set; }
        public HIEOption? HIEOption { get; set; }

        [ForeignKey(nameof(AEEGOption))]
        public int? AEEGOptionId { get; set; }
        public AEEGOption? AEEGOption { get; set; }

        [ForeignKey(nameof(WhyaEEGNotDoneOption))]
        public int? WhyaEEGNotDoneOptionId { get; set; }
        public WhyaEEGNotDoneOption? WhyaEEGNotDoneOption { get; set; }

        public string? aEEGFinding { get; set; }

        [ForeignKey(nameof(CerebralCoolingOption))]
        public int? CerebralCoolingOptionId { get; set; }
        public CerebralCoolingOption? CerebralCoolingOption { get; set; }

        [ForeignKey(nameof(ReasonForNotCoolingOption))]
        public int? ReasonForNotCoolingOptionId { get; set; }
        public ReasonForNotCoolingOption? ReasonForNotCoolingOption { get; set; }

        [ForeignKey(nameof(CoolingTypeOption))]
        public int? CoolingTypeOptionId { get; set; }
        public CoolingTypeOption? CoolingTypeOption { get; set; }

        [ForeignKey(nameof(NecrotisingEntrocoliisOption))]
        public int? NecrotisingEntrocoliisOptionId { get; set; }
        public NecrotisingEntrocoliisOption? NecrotisingEntrocoliisOption { get; set; }

        [ForeignKey(nameof(ParentalNutritionOption))]
        public int? ParentalNutritionOptionId { get; set; }
        public ParentalNutritionOption? ParentalNutritionOption { get; set; }

        public bool? NECSurgery { get; set; }
        public bool? OtherSurgery { get; set; }

        [ForeignKey(nameof(TypeOfNECSurgeryOption))]
        public int? TypeOfNECSurgeryOptionId { get; set; }
        public TypeOfNECSurgeryOption? TypeOfNECSurgeryOption { get; set; }

        public string? SurgeryCode1 { get; set; }
        public string? SurgeryCode2 { get; set; }
        public string? SurgeryCode3 { get; set; }
        public string? SurgeryCode4 { get; set; }

        [ForeignKey(nameof(RetinopathyOfPrematurityOption))]
        public int? RetinopathyOfPrematurityOptionId { get; set; }
        public RetinopathyOfPrematurityOption? RetinopathyOfPrematurityOption { get; set; }

        [ForeignKey(nameof(ROPFindingsOption))]
        public int? ROPFindingsOptionId { get; set; }
        public ROPFindingsOption? ROPFindingsOption { get; set; }

        [ForeignKey(nameof(ROPSurgeryOption))]
        public int? ROPSurgeryOptionId { get; set; }
        public ROPSurgeryOption? ROPSurgeryOption { get; set; }

        [ForeignKey(nameof(NeonatalJaundiceRequirementOption))]
        public int? NeonatalJaundiceRequirementOptionId { get; set; }
        public NeonatalJaundiceRequirementOption? NeonatalJaundiceRequirementOption { get; set; }

        [ForeignKey(nameof(ExchangeTranfusionOption))]
        public int? ExchangeTranfusionOptionId { get; set; }
        public ExchangeTranfusionOption? ExchangeTranfusionOption { get; set; }

        [ForeignKey(nameof(MaxTotalBilirubinLevelOption))]
        public int? MaxTotalBilirubinLevelOptionId { get; set; }
        public MaxTotalBilirubinLevelOption? MaxTotalBilirubinLevelOption { get; set; }

        [ForeignKey(nameof(BloodTransfusionOption))]
        public int? BloodTransfusionOptionId { get; set; }
        public BloodTransfusionOption? BloodTransfusionOption { get; set; }

        [ForeignKey(nameof(PlateletTranfusionOption))]
        public int? PlateletTranfusionOptionId { get; set; }
        public PlateletTranfusionOption? PlateletTranfusionOption { get; set; }

        [ForeignKey(nameof(FreshFrozenPlasmaOption))]
        public int? FreshFrozenPlasmaOptionId { get; set; }
        public FreshFrozenPlasmaOption? FreshFrozenPlasmaOption { get; set; }

        [ForeignKey(nameof(MajorBirthDefectOption))]
        public int? MajorBirthDefectOptionId { get; set; }
        public MajorBirthDefectOption? MajorBirthDefectOption { get; set; }

        public string? Codes { get; set; }
        public string? NonLifeThreat { get; set; }

        [ForeignKey(nameof(KangarooCareOption))]
        public int? KangarooCareOptionId { get; set; }
        public KangarooCareOption? KangarooCareOption { get; set; }

        [ForeignKey(nameof(TypeOfKMCOption))]
        public int? TypeOfKMCOptionId { get; set; }
        public TypeOfKMCOption? TypeOfKMCOption { get; set; }
    }
}
