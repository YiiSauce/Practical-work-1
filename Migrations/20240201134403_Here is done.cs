using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practical_work_1.Migrations
{
    /// <inheritdoc />
    public partial class Hereisdone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Trainees",
                newName: "TaineeName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaineeName",
                table: "Trainees",
                newName: "Name");
        }
    }
}
