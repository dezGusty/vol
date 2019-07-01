using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteersEventsApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Aditionalinfo",
                columns: table => new
                {
                    AditionalinfoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HasDrivingLicence = table.Column<bool>(nullable: false),
                    HasCar = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aditionalinfo", x => x.AditionalinfoID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Days = table.Column<string>(nullable: true),
                    TimeAvailability = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentsID);
                });

            migrationBuilder.CreateTable(
                name: "ContactInformation",
                columns: table => new
                {
                    ContactInformationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhoneNumber = table.Column<string>(nullable: true),
                    MailAdress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformation", x => x.ContactInformationID);
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
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ContractID);
                });

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
                name: "Workschedule",
                columns: table => new
                {
                    WorkscheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HoursWeek = table.Column<string>(nullable: true),
                    CommentsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workschedule", x => x.WorkscheduleID);
                    table.ForeignKey(
                        name: "FK_Workschedule_Comments_CommentsID",
                        column: x => x.CommentsID,
                        principalTable: "Comments",
                        principalColumn: "CommentsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Volunteer",
                columns: table => new
                {
                    VolunteerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Desired_workplace = table.Column<string>(nullable: true),
                    Field_of_activity = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Occupation_description = table.Column<string>(nullable: true),
                    InActivity = table.Column<bool>(nullable: false),
                    HourCount = table.Column<int>(nullable: false),
                    AddressID = table.Column<int>(nullable: true),
                    AditionalinfoID = table.Column<int>(nullable: true),
                    ContractID = table.Column<int>(nullable: true),
                    ContactInformationID = table.Column<int>(nullable: true),
                    WorkscheduleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteer", x => x.VolunteerID);
                    table.ForeignKey(
                        name: "FK_Volunteer_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Volunteer_Aditionalinfo_AditionalinfoID",
                        column: x => x.AditionalinfoID,
                        principalTable: "Aditionalinfo",
                        principalColumn: "AditionalinfoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Volunteer_ContactInformation_ContactInformationID",
                        column: x => x.ContactInformationID,
                        principalTable: "ContactInformation",
                        principalColumn: "ContactInformationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Volunteer_Contract_ContractID",
                        column: x => x.ContractID,
                        principalTable: "Contract",
                        principalColumn: "ContractID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Volunteer_Workschedule_WorkscheduleID",
                        column: x => x.WorkscheduleID,
                        principalTable: "Workschedule",
                        principalColumn: "WorkscheduleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_AddressID",
                table: "Volunteer",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_AditionalinfoID",
                table: "Volunteer",
                column: "AditionalinfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_ContactInformationID",
                table: "Volunteer",
                column: "ContactInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_ContractID",
                table: "Volunteer",
                column: "ContractID");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_WorkscheduleID",
                table: "Volunteer",
                column: "WorkscheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_Workschedule_CommentsID",
                table: "Workschedule",
                column: "CommentsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Volunteer");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Aditionalinfo");

            migrationBuilder.DropTable(
                name: "ContactInformation");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Workschedule");

            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
