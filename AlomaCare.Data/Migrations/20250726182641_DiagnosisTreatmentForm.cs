using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class DiagnosisTreatmentForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientCompleteInfo");

            migrationBuilder.AlterColumn<Guid>(
                name: "SepsisAfterDay3",
                table: "NeonatalSepsis",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "EarlyAntibiotics",
                table: "NeonatalSepsis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "DiagnosisTreatmentForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NeonatalSepsisId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CribScoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CranialUltrasoundInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RespiratoryComplicationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OtherNeonatalComplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OutcomeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisTreatmentForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosisTreatmentForms_CRIBScores_CribScoreId",
                        column: x => x.CribScoreId,
                        principalTable: "CRIBScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisTreatmentForms_CranialUltrasoundInfos_CranialUltrasoundInfoId",
                        column: x => x.CranialUltrasoundInfoId,
                        principalTable: "CranialUltrasoundInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisTreatmentForms_NeonatalSepsis_NeonatalSepsisId",
                        column: x => x.NeonatalSepsisId,
                        principalTable: "NeonatalSepsis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisTreatmentForms_OtherNeonatalComplications_OtherNeonatalComplicationId",
                        column: x => x.OtherNeonatalComplicationId,
                        principalTable: "OtherNeonatalComplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisTreatmentForms_Outcomes_OutcomeId",
                        column: x => x.OutcomeId,
                        principalTable: "Outcomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisTreatmentForms_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiagnosisTreatmentForms_RespiratoryComplications_RespiratoryComplicationsId",
                        column: x => x.RespiratoryComplicationsId,
                        principalTable: "RespiratoryComplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientCompleteInfoDTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NeonatalSepsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongenitalInfection = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CongenitalInfectionOrganism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecifyOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacterialSepsisBeforeDay3 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BsOrganism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EarlyAntibiotics = table.Column<int>(type: "int", nullable: true),
                    SepsisAfterDay3 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SepsisSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacterialPathogen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BacterialInfectionLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Cons = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConsLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OtherBacteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FungalSepsis = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BetaDGlucan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FungalSepsisLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FungalOrganism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LateSepsisAbx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecifyOtherAbx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbxDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbgAvailable = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseExcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribWeightGa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribTemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribBaseExcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribTotal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EosCalcDone = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EosRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EosRecommendation = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EosFollowed = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CranialBefore28 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ivh = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorstIvh = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SonarFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CysticPvl = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OtherSonarFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespiratoryDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PneumoLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RespSupportAfter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HfncHighRate = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    NcpapNoEtt = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeptalNecrosis = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ino = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Oxygen28 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Resp28 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SteroidsCld = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Caffeine = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SurfactantInit = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SurfactantAny = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SvtDoses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SvtFirstHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SvtFirstMinutes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdaLiti = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PdaIbuprofen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PdaParacetamol = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InotropicSupport = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HieSection = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThomsonScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGasResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HieGradeSection = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AeeG = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AeeGNotDoneReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AeeGFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CerebralCooling = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CoolingNotDoneReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NecEnterocolitis = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParenteralNutrition = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NecSurgery = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OtherSurgery = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TypeNecSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetinopathyPre = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RopFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RopSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JaundiceRequirement = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExchangeTransfusion = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaxBilirubin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodTransfusion = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlateletTransfusion = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlasmaTransfusion = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MetabolicComplications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlucoseAbnormalities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MajorBirthDefect = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DefectCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongenitalAnomaly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KangarooCare = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KmcType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutcomeSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedsOnDischarge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeOxygen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DischargeWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationOfStay = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCompleteInfoDTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientCompleteInfoDTO_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisTreatmentForms_CranialUltrasoundInfoId",
                table: "DiagnosisTreatmentForms",
                column: "CranialUltrasoundInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisTreatmentForms_CribScoreId",
                table: "DiagnosisTreatmentForms",
                column: "CribScoreId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisTreatmentForms_NeonatalSepsisId",
                table: "DiagnosisTreatmentForms",
                column: "NeonatalSepsisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisTreatmentForms_OtherNeonatalComplicationId",
                table: "DiagnosisTreatmentForms",
                column: "OtherNeonatalComplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisTreatmentForms_OutcomeId",
                table: "DiagnosisTreatmentForms",
                column: "OutcomeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisTreatmentForms_PatientId",
                table: "DiagnosisTreatmentForms",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisTreatmentForms_RespiratoryComplicationsId",
                table: "DiagnosisTreatmentForms",
                column: "RespiratoryComplicationsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientCompleteInfoDTO_PatientId",
                table: "PatientCompleteInfoDTO",
                column: "PatientId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiagnosisTreatmentForms");

            migrationBuilder.DropTable(
                name: "PatientCompleteInfoDTO");

            migrationBuilder.AlterColumn<Guid>(
                name: "SepsisAfterDay3",
                table: "NeonatalSepsis",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EarlyAntibiotics",
                table: "NeonatalSepsis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PatientCompleteInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AbgAvailable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbxDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AeeG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AeeGFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AeeGNotDoneReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacterialInfectionLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacterialPathogen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacterialSepsisBeforeDay3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseExcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BetaDGlucan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGasResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodTransfusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BsOrganism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caffeine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CerebralCooling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongenitalAnomaly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongenitalInfection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongenitalInfectionOrganism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingNotDoneReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CranialBefore28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribBaseExcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribTemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribTotal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CribWeightGa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CysticPvl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationOfStay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EarlyAntibiotics = table.Column<int>(type: "int", nullable: true),
                    EosCalcDone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EosFollowed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EosRecommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EosRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExchangeTransfusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedsOnDischarge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FungalOrganism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FungalSepsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FungalSepsisLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlucoseAbnormalities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HfEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HfStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HfncHighRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HieGradeSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HieSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeOxygen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InotropicSupport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ivh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JaundiceRequirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KangarooCare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KmcType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LateSepsisAbx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MajorBirthDefect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxBilirubin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetabolicComplications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ncpap2Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ncpap2End = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ncpap2Start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NcpapDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NcpapEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NcpapNoEtt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NcpapStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NecEnterocolitis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NecSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeonatalSepsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherBacteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherSonarFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutcomeSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oxygen28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParenteralNutrition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdaIbuprofen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdaLiti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdaParacetamol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlasmaTransfusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlateletTransfusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PneumoLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resp28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespSupportAfter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespiratoryDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetinopathyPre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RopFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RopSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SepsisAfterDay3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SepsisSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeptalNecrosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SonarFindings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecifyOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecifyOtherAbx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SteroidsCld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfactantAny = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfactantInit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryCode4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SvtDoses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SvtFirstHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SvtFirstMinutes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThomsonScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeNecSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent1Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent1End = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent1Start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent2Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent2End = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vent2Start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorstIvh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCompleteInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientCompleteInfo_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientCompleteInfo_PatientId",
                table: "PatientCompleteInfo",
                column: "PatientId",
                unique: true);
        }
    }
}
