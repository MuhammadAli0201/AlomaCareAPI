using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class AddPPIPFormAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvoidableFactors",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConditionAtBirth",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfDeath",
                table: "Patients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MothersGtNumber",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NeonatalCauseOfDeath",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObstetricCauseOfDeath",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SingleOrMultipleBirths",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SyphilisSerology",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvoidableFactors",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ConditionAtBirth",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DateOfDeath",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MothersGtNumber",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "NeonatalCauseOfDeath",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ObstetricCauseOfDeath",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SingleOrMultipleBirths",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SyphilisSerology",
                table: "Patients");
        }
    }
}
