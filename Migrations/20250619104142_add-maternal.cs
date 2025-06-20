using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCareAPI.Migrations
{
    /// <inheritdoc />
    public partial class addmaternal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MaternalId",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Maternals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Parity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gravidity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AntenatalCare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AntenatalSteroid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AntenatalMgSulfate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chorioamnionitis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hypertension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaternalHiv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HivProphylaxis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaartBegun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Syphilis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SyphilisTreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diabetes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TbTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeenageMother = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbandonedBaby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeonatalAbstinence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultipleGestations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfBabies = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Maternals_PatientId",
                table: "Maternals",
                column: "PatientId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maternals");

            migrationBuilder.DropColumn(
                name: "MaternalId",
                table: "Patients");
        }
    }
}
