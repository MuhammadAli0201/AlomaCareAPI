using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class patient_full_information : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    EarlyAntibiotics = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    KmcType = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "IX_PatientCompleteInfos_PatientId",
                table: "PatientCompleteInfos",
                column: "PatientId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientCompleteInfos");
        }
    }
}
