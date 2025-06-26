using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCareAPI.Migrations
{
    /// <inheritdoc />
    public partial class convertapgarselecttotextboxes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApgarTimes",
                table: "Patients",
                newName: "TenMinuteApgar");

            migrationBuilder.AddColumn<string>(
                name: "FiveMinuteApgar",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OneMinuteApgar",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FiveMinuteApgar",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "OneMinuteApgar",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "TenMinuteApgar",
                table: "Patients",
                newName: "ApgarTimes");
        }
    }
}
