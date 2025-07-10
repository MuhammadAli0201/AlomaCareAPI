using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Migrations
{
    /// <inheritdoc />
    public partial class addmaternal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HospitalNumber",
                table: "Maternals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Maternals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "Maternals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Maternals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Maternals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HospitalNumber",
                table: "Maternals");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Maternals");

            migrationBuilder.DropColumn(
                name: "Race",
                table: "Maternals");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Maternals");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Maternals");
        }
    }
}
