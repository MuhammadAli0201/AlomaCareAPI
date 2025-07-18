using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AEEGOptions",
                columns: table => new
                {
                    AEEGOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AEEGName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AEEGOptions", x => x.AEEGOptionId);
                });

            migrationBuilder.CreateTable(
                name: "Antimicrobials",
                columns: table => new
                {
                    AntimicrobialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntimicrobialName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antimicrobials", x => x.AntimicrobialID);
                });

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    AuditLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.AuditLogId);
                });

            migrationBuilder.CreateTable(
                name: "BloodTransfusionOptions",
                columns: table => new
                {
                    BloodTransfusionOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodTransfusionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTransfusionOptions", x => x.BloodTransfusionOptionId);
                });

            migrationBuilder.CreateTable(
                name: "Cardiovasculars",
                columns: table => new
                {
                    CardiovascularId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardiovascularName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cardiovasculars", x => x.CardiovascularId);
                });

            migrationBuilder.CreateTable(
                name: "CerebralCoolingOptions",
                columns: table => new
                {
                    CerebralCoolingOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CerebralCoolingName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CerebralCoolingOptions", x => x.CerebralCoolingOptionId);
                });

            migrationBuilder.CreateTable(
                name: "CNSs",
                columns: table => new
                {
                    CNSId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNSName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CNSs", x => x.CNSId);
                });

            migrationBuilder.CreateTable(
                name: "CongenitalInfectionOrganisms",
                columns: table => new
                {
                    CongenitalInfectionOrganismID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongenitalInfectionOrganismName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongenitalInfectionOrganisms", x => x.CongenitalInfectionOrganismID);
                });

            migrationBuilder.CreateTable(
                name: "CoolingTypeOptions",
                columns: table => new
                {
                    CoolingTypeOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoolingTypeOptionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoolingTypeOptions", x => x.CoolingTypeOptionId);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeTranfusionOptions",
                columns: table => new
                {
                    ExchangeTranfusionOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExchangeTranfusionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeTranfusionOptions", x => x.ExchangeTranfusionOptionId);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FreshFrozenPlasmaOptions",
                columns: table => new
                {
                    FreshFrozenPlasmaOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreshFrozenPlasmaName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreshFrozenPlasmaOptions", x => x.FreshFrozenPlasmaOptionId);
                });

            migrationBuilder.CreateTable(
                name: "FungalOrganisms",
                columns: table => new
                {
                    FungalOrganismID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FungalOrganismName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FungalOrganisms", x => x.FungalOrganismID);
                });

            migrationBuilder.CreateTable(
                name: "GlucoseAbnormalities",
                columns: table => new
                {
                    GlucoseAbnormalitiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlucoseAbnormalitiesName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlucoseAbnormalities", x => x.GlucoseAbnormalitiesId);
                });

            migrationBuilder.CreateTable(
                name: "HelpResources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpResources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HIEOptions",
                columns: table => new
                {
                    HIEOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HIEOptionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HIEOptions", x => x.HIEOptionId);
                });

            migrationBuilder.CreateTable(
                name: "IbuprofenForPDAOptions",
                columns: table => new
                {
                    IbuprofenForPDAOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IbuprofenForPDAName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IbuprofenForPDAOptions", x => x.IbuprofenForPDAOptionId);
                });

            migrationBuilder.CreateTable(
                name: "IntropicSupportOptions",
                columns: table => new
                {
                    IntropicSupportOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntropicSupportName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntropicSupportOptions", x => x.IntropicSupportOptionId);
                });

            migrationBuilder.CreateTable(
                name: "KangarooCareOptions",
                columns: table => new
                {
                    KangarooCareOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KangarooCareName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KangarooCareOptions", x => x.KangarooCareOptionId);
                });

            migrationBuilder.CreateTable(
                name: "MajorBirthDefectOptions",
                columns: table => new
                {
                    MajorBirthDefectOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorBirthDefectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorBirthDefectOptions", x => x.MajorBirthDefectOptionId);
                });

            migrationBuilder.CreateTable(
                name: "MaxTotalBilirubinLevelOptions",
                columns: table => new
                {
                    MaxTotalBilirubinLevelOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxTotalBilirubinLevelName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaxTotalBilirubinLevelOptions", x => x.MaxTotalBilirubinLevelOptionId);
                });

            migrationBuilder.CreateTable(
                name: "Metabolics",
                columns: table => new
                {
                    MetabolicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetabolicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metabolics", x => x.MetabolicId);
                });

            migrationBuilder.CreateTable(
                name: "NecrotisingEntrocoliisOptions",
                columns: table => new
                {
                    NecrotisingEntrocoliisOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NecrotisingEntrocoliisName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NecrotisingEntrocoliisOptions", x => x.NecrotisingEntrocoliisOptionId);
                });

            migrationBuilder.CreateTable(
                name: "NeonatalJaundiceRequirementOptions",
                columns: table => new
                {
                    NeonatalJaundiceRequirementOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NeonatalJaundiceRequirementName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeonatalJaundiceRequirementOptions", x => x.NeonatalJaundiceRequirementOptionId);
                });

            migrationBuilder.CreateTable(
                name: "organisms",
                columns: table => new
                {
                    OrganismID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganismName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organisms", x => x.OrganismID);
                });

            migrationBuilder.CreateTable(
                name: "OtherNeonatalComplicationCardiovasculars",
                columns: table => new
                {
                    OtherNeonatalComplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardiovascularId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherNeonatalComplicationCardiovasculars", x => x.OtherNeonatalComplicationId);
                });

            migrationBuilder.CreateTable(
                name: "OtherNeonatalComplicationCNSs",
                columns: table => new
                {
                    OtherNeonatalComplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNSId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherNeonatalComplicationCNSs", x => x.OtherNeonatalComplicationId);
                });

            migrationBuilder.CreateTable(
                name: "OtherNeonatalComplicationGlucoseAbnormalitiess",
                columns: table => new
                {
                    OtherNeonatalComplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlucoseAbnormalitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherNeonatalComplicationGlucoseAbnormalitiess", x => x.OtherNeonatalComplicationId);
                });

            migrationBuilder.CreateTable(
                name: "OtherNeonatalComplicationMetabolics",
                columns: table => new
                {
                    OtherNeonatalComplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetabolicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherNeonatalComplicationMetabolics", x => x.OtherNeonatalComplicationId);
                });

            migrationBuilder.CreateTable(
                name: "ParacetamolForPDAOptions",
                columns: table => new
                {
                    ParacetamolForPDAOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParacetamolForPDAName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParacetamolForPDAOptions", x => x.ParacetamolForPDAOptionId);
                });

            migrationBuilder.CreateTable(
                name: "ParentalNutritionOptions",
                columns: table => new
                {
                    ParentalNutritionOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentalNutritionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentalNutritionOptions", x => x.ParentalNutritionOptionId);
                });

            migrationBuilder.CreateTable(
                name: "PDALitigationOptions",
                columns: table => new
                {
                    PDALitigationOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PDALitigationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDALitigationOptions", x => x.PDALitigationOptionId);
                });

            migrationBuilder.CreateTable(
                name: "PlateletTranfusionOptions",
                columns: table => new
                {
                    PlateletTranfusionOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlateletTranfusionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlateletTranfusionOptions", x => x.PlateletTranfusionOptionId);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "ReasonForNotCoolingOptions",
                columns: table => new
                {
                    ReasonForNotCoolingOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReasonForNotCoolingName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonForNotCoolingOptions", x => x.ReasonForNotCoolingOptionId);
                });

            migrationBuilder.CreateTable(
                name: "RetinopathyOfPrematurityOptions",
                columns: table => new
                {
                    RetinopathyOfPrematurityOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RetinopathyOfPrematurityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetinopathyOfPrematurityOptions", x => x.RetinopathyOfPrematurityOptionId);
                });

            migrationBuilder.CreateTable(
                name: "ROPFindingsOptions",
                columns: table => new
                {
                    ROPFindingsOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ROPFindingsName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROPFindingsOptions", x => x.ROPFindingsOptionId);
                });

            migrationBuilder.CreateTable(
                name: "ROPSurgeryOptions",
                columns: table => new
                {
                    ROPSurgeryOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ROPSurgeryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROPSurgeryOptions", x => x.ROPSurgeryOptionId);
                });

            migrationBuilder.CreateTable(
                name: "SonarFindings",
                columns: table => new
                {
                    SonarFindingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SonarFindingName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonarFindings", x => x.SonarFindingID);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfKMCOptions",
                columns: table => new
                {
                    TypeOfKMCOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfKMCName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfKMCOptions", x => x.TypeOfKMCOptionId);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfNECSurgeryOptions",
                columns: table => new
                {
                    TypeOfNECSurgeryOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfNECSurgeryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfNECSurgeryOptions", x => x.TypeOfNECSurgeryOptionId);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usernumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WhyaEEGNotDoneOptions",
                columns: table => new
                {
                    WhyaEEGNotDoneOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhyaEEGNotDoneName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhyaEEGNotDoneOptions", x => x.WhyaEEGNotDoneOptionId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PasswordResets",
                columns: table => new
                {
                    PasswordResetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordResets", x => x.PasswordResetId);
                    table.ForeignKey(
                        name: "FK_PasswordResets_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRoles_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherNeonatalComplications",
                columns: table => new
                {
                    OtherNeonatalComplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CHD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDALitigationOptionId = table.Column<int>(type: "int", nullable: true),
                    IbuprofenForPDAOptionId = table.Column<int>(type: "int", nullable: true),
                    ParacetamolForPDAOptionId = table.Column<int>(type: "int", nullable: true),
                    InotropicSupportOptionId = table.Column<int>(type: "int", nullable: true),
                    HIE = table.Column<bool>(type: "bit", nullable: true),
                    ThomsonScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGasResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIEOptionId = table.Column<int>(type: "int", nullable: true),
                    AEEGOptionId = table.Column<int>(type: "int", nullable: true),
                    WhyaEEGNotDoneOptionId = table.Column<int>(type: "int", nullable: true),
                    aEEGFinding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CerebralCoolingOptionId = table.Column<int>(type: "int", nullable: true),
                    ReasonForNotCoolingOptionId = table.Column<int>(type: "int", nullable: true),
                    CoolingTypeOptionId = table.Column<int>(type: "int", nullable: true),
                    NecrotisingEntrocoliisOptionId = table.Column<int>(type: "int", nullable: true),
                    ParentalNutritionOptionId = table.Column<int>(type: "int", nullable: true),
                    NECSurgery = table.Column<bool>(type: "bit", nullable: true),
                    OtherSurgery = table.Column<bool>(type: "bit", nullable: true),
                    TypeOfNECSurgeryOptionId = table.Column<int>(type: "int", nullable: true),
                    SurgeryCode1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetinopathyOfPrematurityOptionId = table.Column<int>(type: "int", nullable: true),
                    ROPFindingsOptionId = table.Column<int>(type: "int", nullable: true),
                    ROPSurgeryOptionId = table.Column<int>(type: "int", nullable: true),
                    NeonatalJaundiceRequirementOptionId = table.Column<int>(type: "int", nullable: true),
                    ExchangeTranfusionOptionId = table.Column<int>(type: "int", nullable: true),
                    MaxTotalBilirubinLevelOptionId = table.Column<int>(type: "int", nullable: true),
                    BloodTransfusionOptionId = table.Column<int>(type: "int", nullable: true),
                    PlateletTranfusionOptionId = table.Column<int>(type: "int", nullable: true),
                    FreshFrozenPlasmaOptionId = table.Column<int>(type: "int", nullable: true),
                    MajorBirthDefectOptionId = table.Column<int>(type: "int", nullable: true),
                    Codes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NonLifeThreat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KangarooCareOptionId = table.Column<int>(type: "int", nullable: true),
                    TypeOfKMCOptionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherNeonatalComplications", x => x.OtherNeonatalComplicationId);
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_AEEGOptions_AEEGOptionId",
                        column: x => x.AEEGOptionId,
                        principalTable: "AEEGOptions",
                        principalColumn: "AEEGOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_BloodTransfusionOptions_BloodTransfusionOptionId",
                        column: x => x.BloodTransfusionOptionId,
                        principalTable: "BloodTransfusionOptions",
                        principalColumn: "BloodTransfusionOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_CerebralCoolingOptions_CerebralCoolingOptionId",
                        column: x => x.CerebralCoolingOptionId,
                        principalTable: "CerebralCoolingOptions",
                        principalColumn: "CerebralCoolingOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_CoolingTypeOptions_CoolingTypeOptionId",
                        column: x => x.CoolingTypeOptionId,
                        principalTable: "CoolingTypeOptions",
                        principalColumn: "CoolingTypeOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_ExchangeTranfusionOptions_ExchangeTranfusionOptionId",
                        column: x => x.ExchangeTranfusionOptionId,
                        principalTable: "ExchangeTranfusionOptions",
                        principalColumn: "ExchangeTranfusionOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_FreshFrozenPlasmaOptions_FreshFrozenPlasmaOptionId",
                        column: x => x.FreshFrozenPlasmaOptionId,
                        principalTable: "FreshFrozenPlasmaOptions",
                        principalColumn: "FreshFrozenPlasmaOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_HIEOptions_HIEOptionId",
                        column: x => x.HIEOptionId,
                        principalTable: "HIEOptions",
                        principalColumn: "HIEOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_IbuprofenForPDAOptions_IbuprofenForPDAOptionId",
                        column: x => x.IbuprofenForPDAOptionId,
                        principalTable: "IbuprofenForPDAOptions",
                        principalColumn: "IbuprofenForPDAOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_IntropicSupportOptions_InotropicSupportOptionId",
                        column: x => x.InotropicSupportOptionId,
                        principalTable: "IntropicSupportOptions",
                        principalColumn: "IntropicSupportOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_KangarooCareOptions_KangarooCareOptionId",
                        column: x => x.KangarooCareOptionId,
                        principalTable: "KangarooCareOptions",
                        principalColumn: "KangarooCareOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_MajorBirthDefectOptions_MajorBirthDefectOptionId",
                        column: x => x.MajorBirthDefectOptionId,
                        principalTable: "MajorBirthDefectOptions",
                        principalColumn: "MajorBirthDefectOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_MaxTotalBilirubinLevelOptions_MaxTotalBilirubinLevelOptionId",
                        column: x => x.MaxTotalBilirubinLevelOptionId,
                        principalTable: "MaxTotalBilirubinLevelOptions",
                        principalColumn: "MaxTotalBilirubinLevelOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_NecrotisingEntrocoliisOptions_NecrotisingEntrocoliisOptionId",
                        column: x => x.NecrotisingEntrocoliisOptionId,
                        principalTable: "NecrotisingEntrocoliisOptions",
                        principalColumn: "NecrotisingEntrocoliisOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_NeonatalJaundiceRequirementOptions_NeonatalJaundiceRequirementOptionId",
                        column: x => x.NeonatalJaundiceRequirementOptionId,
                        principalTable: "NeonatalJaundiceRequirementOptions",
                        principalColumn: "NeonatalJaundiceRequirementOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_PDALitigationOptions_PDALitigationOptionId",
                        column: x => x.PDALitigationOptionId,
                        principalTable: "PDALitigationOptions",
                        principalColumn: "PDALitigationOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_ParacetamolForPDAOptions_ParacetamolForPDAOptionId",
                        column: x => x.ParacetamolForPDAOptionId,
                        principalTable: "ParacetamolForPDAOptions",
                        principalColumn: "ParacetamolForPDAOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_ParentalNutritionOptions_ParentalNutritionOptionId",
                        column: x => x.ParentalNutritionOptionId,
                        principalTable: "ParentalNutritionOptions",
                        principalColumn: "ParentalNutritionOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_PlateletTranfusionOptions_PlateletTranfusionOptionId",
                        column: x => x.PlateletTranfusionOptionId,
                        principalTable: "PlateletTranfusionOptions",
                        principalColumn: "PlateletTranfusionOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_ROPFindingsOptions_ROPFindingsOptionId",
                        column: x => x.ROPFindingsOptionId,
                        principalTable: "ROPFindingsOptions",
                        principalColumn: "ROPFindingsOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_ROPSurgeryOptions_ROPSurgeryOptionId",
                        column: x => x.ROPSurgeryOptionId,
                        principalTable: "ROPSurgeryOptions",
                        principalColumn: "ROPSurgeryOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_ReasonForNotCoolingOptions_ReasonForNotCoolingOptionId",
                        column: x => x.ReasonForNotCoolingOptionId,
                        principalTable: "ReasonForNotCoolingOptions",
                        principalColumn: "ReasonForNotCoolingOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_RetinopathyOfPrematurityOptions_RetinopathyOfPrematurityOptionId",
                        column: x => x.RetinopathyOfPrematurityOptionId,
                        principalTable: "RetinopathyOfPrematurityOptions",
                        principalColumn: "RetinopathyOfPrematurityOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_TypeOfKMCOptions_TypeOfKMCOptionId",
                        column: x => x.TypeOfKMCOptionId,
                        principalTable: "TypeOfKMCOptions",
                        principalColumn: "TypeOfKMCOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_TypeOfNECSurgeryOptions_TypeOfNECSurgeryOptionId",
                        column: x => x.TypeOfNECSurgeryOptionId,
                        principalTable: "TypeOfNECSurgeryOptions",
                        principalColumn: "TypeOfNECSurgeryOptionId");
                    table.ForeignKey(
                        name: "FK_OtherNeonatalComplications_WhyaEEGNotDoneOptions_WhyaEEGNotDoneOptionId",
                        column: x => x.WhyaEEGNotDoneOptionId,
                        principalTable: "WhyaEEGNotDoneOptions",
                        principalColumn: "WhyaEEGNotDoneOptionId");
                });

            migrationBuilder.CreateTable(
                name: "Suburbs",
                columns: table => new
                {
                    SuburbId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suburbs", x => x.SuburbId);
                    table.ForeignKey(
                        name: "FK_Suburbs_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    SuburbId = table.Column<int>(type: "int", nullable: false),
                    SuburbId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalId);
                    table.ForeignKey(
                        name: "FK_Hospitals_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                    table.ForeignKey(
                        name: "FK_Hospitals_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceId");
                    table.ForeignKey(
                        name: "FK_Hospitals_Suburbs_SuburbId",
                        column: x => x.SuburbId,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbId");
                    table.ForeignKey(
                        name: "FK_Hospitals_Suburbs_SuburbId1",
                        column: x => x.SuburbId1,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbId");
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HospitalNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgeOnAdmission = table.Column<int>(type: "int", nullable: true),
                    BirthWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GestationalUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GestationalAge = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    SuburbId = table.Column<int>(type: "int", nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
                    ModeOfDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InitialResuscitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OneMinuteApgar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiveMinuteApgar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenMinuteApgar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutcomeStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransferHospital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthHivPcr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadCircumference = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FootLength = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LengthAtBirth = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiedInDeliveryRoom = table.Column<bool>(type: "bit", nullable: false),
                    DiedWithin12Hours = table.Column<bool>(type: "bit", nullable: false),
                    InitialTemperature = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MothersGtNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConditionAtBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SyphilisSerology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SingleOrMultipleBirths = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObstetricCauseOfDeath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeonatalCauseOfDeath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidableFactors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                    table.ForeignKey(
                        name: "FK_Patients_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId");
                    table.ForeignKey(
                        name: "FK_Patients_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceId");
                    table.ForeignKey(
                        name: "FK_Patients_Suburbs_SuburbId",
                        column: x => x.SuburbId,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbId");
                    table.ForeignKey(
                        name: "FK_Patients_users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maternals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HospitalNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: true),
                    Parity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gravidity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AntenatalCare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AntenatalSteroid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AntenatalMgSulfate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chorioamnionitis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hypertension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaternalHiv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HivProphylaxis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaartBegun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Syphilis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SyphilisTreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diabetes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TbTreatment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeenageMother = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbandonedBaby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeonatalAbstinence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MultipleGestations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfBabies = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maternals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maternals_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientCompleteInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NeonatalSepsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongenitalInfection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongenitalInfectionOrganism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecifyOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacterialSepsisBeforeDay3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BsOrganism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EarlyAntibiotics = table.Column<int>(type: "int", nullable: true),
                    SepsisAfterDay3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SepsisSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacterialPathogen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacterialInfectionLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherBacteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FungalSepsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BetaDGlucan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FungalSepsisLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FungalOrganism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LateSepsisAbx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecifyOtherAbx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbxDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbgAvailable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseExcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribWeightGa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribTemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribBaseExcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribTotal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EosCalcDone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EosRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EosRecommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EosFollowed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CranialBefore28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ivh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorstIvh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SonarFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CysticPvl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherSonarFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespiratoryDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PneumoLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespSupportAfter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HfncHighRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HfStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HfEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NcpapStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NcpapEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NcpapDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ncpap2Start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ncpap2End = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ncpap2Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent1Start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent1End = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent1Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent2Start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent2End = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent2Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NcpapNoEtt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeptalNecrosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oxygen28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resp28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SteroidsCld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caffeine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfactantInit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfactantAny = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SvtDoses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SvtFirstHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SvtFirstMinutes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdaLiti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdaIbuprofen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdaParacetamol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InotropicSupport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HieSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThomsonScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGasResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HieGradeSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AeeG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AeeGNotDoneReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AeeGFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CerebralCooling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingNotDoneReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NecEnterocolitis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParenteralNutrition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NecSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeNecSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetinopathyPre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RopFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RopSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JaundiceRequirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExchangeTransfusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxBilirubin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodTransfusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlateletTransfusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlasmaTransfusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetabolicComplications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlucoseAbnormalities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MajorBirthDefect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongenitalAnomaly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KangarooCare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KmcType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutcomeSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedsOnDischarge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeOxygen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationOfStay = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCompleteInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientCompleteInfos_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_CityId",
                table: "Hospitals",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_ProvinceId",
                table: "Hospitals",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_SuburbId",
                table: "Hospitals",
                column: "SuburbId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_SuburbId1",
                table: "Hospitals",
                column: "SuburbId1");

            migrationBuilder.CreateIndex(
                name: "IX_Maternals_PatientId",
                table: "Maternals",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_AEEGOptionId",
                table: "OtherNeonatalComplications",
                column: "AEEGOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_BloodTransfusionOptionId",
                table: "OtherNeonatalComplications",
                column: "BloodTransfusionOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_CerebralCoolingOptionId",
                table: "OtherNeonatalComplications",
                column: "CerebralCoolingOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_CoolingTypeOptionId",
                table: "OtherNeonatalComplications",
                column: "CoolingTypeOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_ExchangeTranfusionOptionId",
                table: "OtherNeonatalComplications",
                column: "ExchangeTranfusionOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_FreshFrozenPlasmaOptionId",
                table: "OtherNeonatalComplications",
                column: "FreshFrozenPlasmaOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_HIEOptionId",
                table: "OtherNeonatalComplications",
                column: "HIEOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_IbuprofenForPDAOptionId",
                table: "OtherNeonatalComplications",
                column: "IbuprofenForPDAOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_InotropicSupportOptionId",
                table: "OtherNeonatalComplications",
                column: "InotropicSupportOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_KangarooCareOptionId",
                table: "OtherNeonatalComplications",
                column: "KangarooCareOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_MajorBirthDefectOptionId",
                table: "OtherNeonatalComplications",
                column: "MajorBirthDefectOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_MaxTotalBilirubinLevelOptionId",
                table: "OtherNeonatalComplications",
                column: "MaxTotalBilirubinLevelOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_NecrotisingEntrocoliisOptionId",
                table: "OtherNeonatalComplications",
                column: "NecrotisingEntrocoliisOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_NeonatalJaundiceRequirementOptionId",
                table: "OtherNeonatalComplications",
                column: "NeonatalJaundiceRequirementOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_ParacetamolForPDAOptionId",
                table: "OtherNeonatalComplications",
                column: "ParacetamolForPDAOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_ParentalNutritionOptionId",
                table: "OtherNeonatalComplications",
                column: "ParentalNutritionOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_PDALitigationOptionId",
                table: "OtherNeonatalComplications",
                column: "PDALitigationOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_PlateletTranfusionOptionId",
                table: "OtherNeonatalComplications",
                column: "PlateletTranfusionOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_ReasonForNotCoolingOptionId",
                table: "OtherNeonatalComplications",
                column: "ReasonForNotCoolingOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_RetinopathyOfPrematurityOptionId",
                table: "OtherNeonatalComplications",
                column: "RetinopathyOfPrematurityOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_ROPFindingsOptionId",
                table: "OtherNeonatalComplications",
                column: "ROPFindingsOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_ROPSurgeryOptionId",
                table: "OtherNeonatalComplications",
                column: "ROPSurgeryOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_TypeOfKMCOptionId",
                table: "OtherNeonatalComplications",
                column: "TypeOfKMCOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_TypeOfNECSurgeryOptionId",
                table: "OtherNeonatalComplications",
                column: "TypeOfNECSurgeryOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherNeonatalComplications_WhyaEEGNotDoneOptionId",
                table: "OtherNeonatalComplications",
                column: "WhyaEEGNotDoneOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordResets_UserId_CreatedAtUtc",
                table: "PasswordResets",
                columns: new[] { "UserId", "CreatedAtUtc" });

            migrationBuilder.CreateIndex(
                name: "IX_PatientCompleteInfos_PatientId",
                table: "PatientCompleteInfos",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CityId",
                table: "Patients",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CreatedByUserId",
                table: "Patients",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_HospitalId",
                table: "Patients",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ProvinceId",
                table: "Patients",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_SuburbId",
                table: "Patients",
                column: "SuburbId");

            migrationBuilder.CreateIndex(
                name: "IX_Suburbs_CityId",
                table: "Suburbs",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Antimicrobials");

            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Cardiovasculars");

            migrationBuilder.DropTable(
                name: "CNSs");

            migrationBuilder.DropTable(
                name: "CongenitalInfectionOrganisms");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "FungalOrganisms");

            migrationBuilder.DropTable(
                name: "GlucoseAbnormalities");

            migrationBuilder.DropTable(
                name: "HelpResources");

            migrationBuilder.DropTable(
                name: "Maternals");

            migrationBuilder.DropTable(
                name: "Metabolics");

            migrationBuilder.DropTable(
                name: "organisms");

            migrationBuilder.DropTable(
                name: "OtherNeonatalComplicationCardiovasculars");

            migrationBuilder.DropTable(
                name: "OtherNeonatalComplicationCNSs");

            migrationBuilder.DropTable(
                name: "OtherNeonatalComplicationGlucoseAbnormalitiess");

            migrationBuilder.DropTable(
                name: "OtherNeonatalComplicationMetabolics");

            migrationBuilder.DropTable(
                name: "OtherNeonatalComplications");

            migrationBuilder.DropTable(
                name: "PasswordResets");

            migrationBuilder.DropTable(
                name: "PatientCompleteInfos");

            migrationBuilder.DropTable(
                name: "SonarFindings");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "AEEGOptions");

            migrationBuilder.DropTable(
                name: "BloodTransfusionOptions");

            migrationBuilder.DropTable(
                name: "CerebralCoolingOptions");

            migrationBuilder.DropTable(
                name: "CoolingTypeOptions");

            migrationBuilder.DropTable(
                name: "ExchangeTranfusionOptions");

            migrationBuilder.DropTable(
                name: "FreshFrozenPlasmaOptions");

            migrationBuilder.DropTable(
                name: "HIEOptions");

            migrationBuilder.DropTable(
                name: "IbuprofenForPDAOptions");

            migrationBuilder.DropTable(
                name: "IntropicSupportOptions");

            migrationBuilder.DropTable(
                name: "KangarooCareOptions");

            migrationBuilder.DropTable(
                name: "MajorBirthDefectOptions");

            migrationBuilder.DropTable(
                name: "MaxTotalBilirubinLevelOptions");

            migrationBuilder.DropTable(
                name: "NecrotisingEntrocoliisOptions");

            migrationBuilder.DropTable(
                name: "NeonatalJaundiceRequirementOptions");

            migrationBuilder.DropTable(
                name: "PDALitigationOptions");

            migrationBuilder.DropTable(
                name: "ParacetamolForPDAOptions");

            migrationBuilder.DropTable(
                name: "ParentalNutritionOptions");

            migrationBuilder.DropTable(
                name: "PlateletTranfusionOptions");

            migrationBuilder.DropTable(
                name: "ROPFindingsOptions");

            migrationBuilder.DropTable(
                name: "ROPSurgeryOptions");

            migrationBuilder.DropTable(
                name: "ReasonForNotCoolingOptions");

            migrationBuilder.DropTable(
                name: "RetinopathyOfPrematurityOptions");

            migrationBuilder.DropTable(
                name: "TypeOfKMCOptions");

            migrationBuilder.DropTable(
                name: "TypeOfNECSurgeryOptions");

            migrationBuilder.DropTable(
                name: "WhyaEEGNotDoneOptions");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Suburbs");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
