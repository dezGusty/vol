using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteersEventsApp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allocate_Event_EventID",
                table: "Allocate");

            migrationBuilder.DropForeignKey(
                name: "FK_Allocate_Volunteer_VolunteerID",
                table: "Allocate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Allocate",
                table: "Allocate");

            migrationBuilder.RenameTable(
                name: "Allocate",
                newName: "Allocate_1");

            migrationBuilder.RenameIndex(
                name: "IX_Allocate_VolunteerID",
                table: "Allocate_1",
                newName: "IX_Allocate_1_VolunteerID");

            migrationBuilder.RenameIndex(
                name: "IX_Allocate_EventID",
                table: "Allocate_1",
                newName: "IX_Allocate_1_EventID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Allocate_1",
                table: "Allocate_1",
                column: "AllocateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Allocate_1_Event_EventID",
                table: "Allocate_1",
                column: "EventID",
                principalTable: "Event",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Allocate_1_Volunteer_VolunteerID",
                table: "Allocate_1",
                column: "VolunteerID",
                principalTable: "Volunteer",
                principalColumn: "VolunteerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allocate_1_Event_EventID",
                table: "Allocate_1");

            migrationBuilder.DropForeignKey(
                name: "FK_Allocate_1_Volunteer_VolunteerID",
                table: "Allocate_1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Allocate_1",
                table: "Allocate_1");

            migrationBuilder.RenameTable(
                name: "Allocate_1",
                newName: "Allocate");

            migrationBuilder.RenameIndex(
                name: "IX_Allocate_1_VolunteerID",
                table: "Allocate",
                newName: "IX_Allocate_VolunteerID");

            migrationBuilder.RenameIndex(
                name: "IX_Allocate_1_EventID",
                table: "Allocate",
                newName: "IX_Allocate_EventID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Allocate",
                table: "Allocate",
                column: "AllocateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Allocate_Event_EventID",
                table: "Allocate",
                column: "EventID",
                principalTable: "Event",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Allocate_Volunteer_VolunteerID",
                table: "Allocate",
                column: "VolunteerID",
                principalTable: "Volunteer",
                principalColumn: "VolunteerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
