using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class patient_full_information_add_section_6_properties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DischargeWeight",
                table: "PatientCompleteInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DurationOfStay",
                table: "PatientCompleteInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeedsOnDischarge",
                table: "PatientCompleteInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeOxygen",
                table: "PatientCompleteInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HospitalName",
                table: "PatientCompleteInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OutcomeSection",
                table: "PatientCompleteInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DischargeWeight",
                table: "PatientCompleteInfos");

            migrationBuilder.DropColumn(
                name: "DurationOfStay",
                table: "PatientCompleteInfos");

            migrationBuilder.DropColumn(
                name: "FeedsOnDischarge",
                table: "PatientCompleteInfos");

            migrationBuilder.DropColumn(
                name: "HomeOxygen",
                table: "PatientCompleteInfos");

            migrationBuilder.DropColumn(
                name: "HospitalName",
                table: "PatientCompleteInfos");

            migrationBuilder.DropColumn(
                name: "OutcomeSection",
                table: "PatientCompleteInfos");
        }
    }
}
