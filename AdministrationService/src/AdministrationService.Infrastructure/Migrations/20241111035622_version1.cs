using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdministrationService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class version1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "UserCredentials");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordSalt",
                table: "UserCredentials",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
