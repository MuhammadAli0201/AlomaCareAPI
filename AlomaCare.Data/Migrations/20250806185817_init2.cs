using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_lookupItems_LookupItem",
                table: "Patients");

            migrationBuilder.AlterColumn<Guid>(
                name: "LookupItem",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_lookupItems_LookupItem",
                table: "Patients",
                column: "LookupItem",
                principalTable: "lookupItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_lookupItems_LookupItem",
                table: "Patients");

            migrationBuilder.AlterColumn<Guid>(
                name: "LookupItem",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_lookupItems_LookupItem",
                table: "Patients",
                column: "LookupItem",
                principalTable: "lookupItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
