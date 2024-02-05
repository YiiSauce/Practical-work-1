using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practical_work_1.Migrations
{
    /// <inheritdoc />
    public partial class other : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaineeName",
                table: "Trainees");

            migrationBuilder.AlterColumn<bool>(
                name: "IsWorking",
                table: "Trainees",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraineeName",
                table: "Trainees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TraineeName",
                table: "Trainees");

            migrationBuilder.AlterColumn<bool>(
                name: "IsWorking",
                table: "Trainees",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "TaineeName",
                table: "Trainees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
