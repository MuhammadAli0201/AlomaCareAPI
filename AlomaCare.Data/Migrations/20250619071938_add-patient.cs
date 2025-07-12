using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class addpatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HospitalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgeOnAdmission = table.Column<int>(type: "int", nullable: false),
                    BirthWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GestationalAge = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeOfDelivery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialResuscitation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApgarTimes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutcomeStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransferHospital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthHivPcr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadCircumference = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FootLength = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LengthAtBirth = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiedInDeliveryRoom = table.Column<bool>(type: "bit", nullable: false),
                    DiedWithin12Hours = table.Column<bool>(type: "bit", nullable: false),
                    InitialTemperature = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CreatedByUserId",
                table: "Patients",
                column: "CreatedByUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
