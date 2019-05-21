using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteersEventsApp.Data.Migrations
{
    public partial class volunteer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfEvent = table.Column<string>(nullable: true),
                    PlaceOfEvent = table.Column<string>(nullable: true),
                    DateOfEvents = table.Column<DateTime>(nullable: false),
                    Lasting = table.Column<int>(nullable: false),
                    NumberOfVolunteersNeeded = table.Column<int>(nullable: false),
                    TypeOfActivities = table.Column<string>(nullable: true),
                    TypeOfEvent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Volunteer",
                columns: table => new
                {
                    VolunteerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Desired_workplace = table.Column<int>(nullable: true),
                    Field_of_activity = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Occupation_description = table.Column<string>(nullable: true),
                    InActivity = table.Column<bool>(nullable: false),
                    HourCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteer", x => x.VolunteerID);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    VolunteerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Address_Volunteer_VolunteerID",
                        column: x => x.VolunteerID,
                        principalTable: "Volunteer",
                        principalColumn: "VolunteerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aditionalinfo",
                columns: table => new
                {
                    AditionalinfoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HasDrivingLicence = table.Column<bool>(nullable: false),
                    HasCar = table.Column<bool>(nullable: false),
                    VolunteerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aditionalinfo", x => x.AditionalinfoID);
                    table.ForeignKey(
                        name: "FK_Aditionalinfo_Volunteer_VolunteerID",
                        column: x => x.VolunteerID,
                        principalTable: "Volunteer",
                        principalColumn: "VolunteerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactInformation",
                columns: table => new
                {
                    ContactInformationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhoneNumber = table.Column<string>(nullable: true),
                    MailAdress = table.Column<string>(nullable: true),
                    VolunteerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformation", x => x.ContactInformationID);
                    table.ForeignKey(
                        name: "FK_ContactInformation_Volunteer_VolunteerID",
                        column: x => x.VolunteerID,
                        principalTable: "Volunteer",
                        principalColumn: "VolunteerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    ContractID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HasContract = table.Column<bool>(nullable: false),
                    ContractPeriod = table.Column<int>(nullable: false),
                    NumberOfRegistration = table.Column<int>(nullable: false),
                    VolunteerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ContractID);
                    table.ForeignKey(
                        name: "FK_Contract_Volunteer_VolunteerID",
                        column: x => x.VolunteerID,
                        principalTable: "Volunteer",
                        principalColumn: "VolunteerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationDay",
                columns: table => new
                {
                    RegistrationDayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Day = table.Column<int>(nullable: false),
                    VolunteerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationDay", x => x.RegistrationDayID);
                    table.ForeignKey(
                        name: "FK_RegistrationDay_Volunteer_VolunteerID",
                        column: x => x.VolunteerID,
                        principalTable: "Volunteer",
                        principalColumn: "VolunteerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workschedule",
                columns: table => new
                {
                    WorkscheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HoursWeek = table.Column<string>(nullable: true),
                    VolunteerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workschedule", x => x.WorkscheduleID);
                    table.ForeignKey(
                        name: "FK_Workschedule_Volunteer_VolunteerID",
                        column: x => x.VolunteerID,
                        principalTable: "Volunteer",
                        principalColumn: "VolunteerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Days = table.Column<int>(nullable: true),
                    TimeAvailability = table.Column<int>(nullable: false),
                    WorkscheduleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentsID);
                    table.ForeignKey(
                        name: "FK_Comments_Workschedule_WorkscheduleID",
                        column: x => x.WorkscheduleID,
                        principalTable: "Workschedule",
                        principalColumn: "WorkscheduleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_VolunteerID",
                table: "Address",
                column: "VolunteerID");

            migrationBuilder.CreateIndex(
                name: "IX_Aditionalinfo_VolunteerID",
                table: "Aditionalinfo",
                column: "VolunteerID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WorkscheduleID",
                table: "Comments",
                column: "WorkscheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformation_VolunteerID",
                table: "ContactInformation",
                column: "VolunteerID");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_VolunteerID",
                table: "Contract",
                column: "VolunteerID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationDay_VolunteerID",
                table: "RegistrationDay",
                column: "VolunteerID");

            migrationBuilder.CreateIndex(
                name: "IX_Workschedule_VolunteerID",
                table: "Workschedule",
                column: "VolunteerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Aditionalinfo");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ContactInformation");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "RegistrationDay");

            migrationBuilder.DropTable(
                name: "Workschedule");

            migrationBuilder.DropTable(
                name: "Volunteer");
        }
    }
}
