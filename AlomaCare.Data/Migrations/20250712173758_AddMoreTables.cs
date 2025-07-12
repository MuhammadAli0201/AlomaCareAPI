using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "BirthWeight",
                table: "Patients",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "AgeOnAdmission",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "age",
                table: "Maternals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Cardiovasculars");

            migrationBuilder.DropTable(
                name: "CNSs");

            migrationBuilder.DropTable(
                name: "GlucoseAbnormalities");

            migrationBuilder.DropTable(
                name: "Metabolics");

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

            migrationBuilder.AlterColumn<decimal>(
                name: "BirthWeight",
                table: "Patients",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgeOnAdmission",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "age",
                table: "Maternals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
