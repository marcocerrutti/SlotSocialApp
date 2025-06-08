using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Longtitude",
                table: "Activities",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "Latitiude",
                table: "Activities",
                newName: "Latitude");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Activities",
                newName: "Longtitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Activities",
                newName: "Latitiude");
        }
    }
}
