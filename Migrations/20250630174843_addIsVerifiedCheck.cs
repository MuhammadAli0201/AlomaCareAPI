using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlomaCareAPI.Migrations
{
    /// <inheritdoc />
    public partial class addIsVerifiedCheck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsVerified",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "users");
        }
    }
}
