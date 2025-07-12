using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuburbName",
                table: "Suburb",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "HospitalName",
                table: "Hospital",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "SuburbId1",
                table: "Hospital",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_SuburbId1",
                table: "Hospital",
                column: "SuburbId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospital_Suburb_SuburbId1",
                table: "Hospital",
                column: "SuburbId1",
                principalTable: "Suburb",
                principalColumn: "SuburbId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospital_Suburb_SuburbId1",
                table: "Hospital");

            migrationBuilder.DropIndex(
                name: "IX_Hospital_SuburbId1",
                table: "Hospital");

            migrationBuilder.DropColumn(
                name: "SuburbId1",
                table: "Hospital");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Suburb",
                newName: "SuburbName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Hospital",
                newName: "HospitalName");
        }
    }
}
