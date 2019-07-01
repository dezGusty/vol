using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteersEventsApp.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimeAvailability",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeAvailability",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
