﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class add_dropdowns_existing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EarlyAntibiotics",
                table: "PatientCompleteInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EarlyAntibiotics",
                table: "PatientCompleteInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
