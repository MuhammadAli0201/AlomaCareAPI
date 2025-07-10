using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hospital",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Suburb",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
