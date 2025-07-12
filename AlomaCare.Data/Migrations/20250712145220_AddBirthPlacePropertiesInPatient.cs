using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthPlacePropertiesInPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Hospital",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Suburb",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HospitalId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuburbId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CityId",
                table: "Patients",
                column: "CityId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Cities_CityId",
                table: "Patients",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Hospitals_HospitalId",
                table: "Patients",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Provinces_ProvinceId",
                table: "Patients",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Suburbs_SuburbId",
                table: "Patients",
                column: "SuburbId",
                principalTable: "Suburbs",
                principalColumn: "SuburbId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Cities_CityId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Hospitals_HospitalId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Provinces_ProvinceId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Suburbs_SuburbId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_CityId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_HospitalId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_ProvinceId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_SuburbId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SuburbId",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hospital",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Suburb",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
