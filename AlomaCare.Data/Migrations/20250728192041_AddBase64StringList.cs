using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBase64StringList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileBase64List",
                table: "PatientCompleteInfoDTO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileBase64List",
                table: "PatientCompleteInfoDTO");
        }
    }
}
