using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteersEventsApp.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allocate",
                columns: table => new
                {
                    AllocateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAllocate = table.Column<bool>(nullable: false),
                    VolunteerID = table.Column<int>(nullable: true),
                    EventID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allocate", x => x.AllocateID);
                    table.ForeignKey(
                        name: "FK_Allocate_Event_EventID",
                        column: x => x.EventID,
                        principalTable: "Event",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Allocate_Volunteer_VolunteerID",
                        column: x => x.VolunteerID,
                        principalTable: "Volunteer",
                        principalColumn: "VolunteerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allocate_EventID",
                table: "Allocate",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_Allocate_VolunteerID",
                table: "Allocate",
                column: "VolunteerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allocate");
        }
    }
}
