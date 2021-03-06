﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Migrations
{
    [DbContext(typeof(VolunteersEventsAppContext))]
    [Migration("20190619080922_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VolunteersEventsApp.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Number");

                    b.Property<string>("Street");

                    b.HasKey("AddressID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Aditionalinfo", b =>
                {
                    b.Property<int>("AditionalinfoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasCar");

                    b.Property<bool>("HasDrivingLicence");

                    b.HasKey("AditionalinfoID");

                    b.ToTable("Aditionalinfo");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Allocate", b =>
                {
                    b.Property<int>("AllocateID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventID");

                    b.Property<bool>("IsAllocate");

                    b.Property<int?>("VolunteerID");

                    b.HasKey("AllocateID");

                    b.HasIndex("EventID");

                    b.HasIndex("VolunteerID");

                    b.ToTable("Allocate_1");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Comments", b =>
                {
                    b.Property<int>("CommentsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Days");

                    b.Property<string>("TimeAvailability");

                    b.HasKey("CommentsID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.ContactInformation", b =>
                {
                    b.Property<int>("ContactInformationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MailAdress");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("ContactInformationID");

                    b.ToTable("ContactInformation");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Contract", b =>
                {
                    b.Property<int>("ContractID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractPeriod");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<bool>("HasContract");

                    b.Property<int>("NumberOfRegistration");

                    b.Property<DateTime>("RegistrationDate");

                    b.HasKey("ContractID");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfEvents");

                    b.Property<int>("Lasting");

                    b.Property<string>("NameOfEvent");

                    b.Property<int>("NumberOfVolunteersNeeded");

                    b.Property<string>("PlaceOfEvent");

                    b.Property<string>("TypeOfActivities");

                    b.Property<string>("TypeOfEvent");

                    b.HasKey("ID");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Volunteer", b =>
                {
                    b.Property<int>("VolunteerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressID");

                    b.Property<int?>("AditionalinfoID");

                    b.Property<int>("Age");

                    b.Property<DateTime>("Birthdate");

                    b.Property<int?>("ContactInformationID");

                    b.Property<int?>("ContractID");

                    b.Property<string>("Desired_workplace");

                    b.Property<string>("Field_of_activity");

                    b.Property<string>("Firstname");

                    b.Property<string>("Gender");

                    b.Property<int>("HourCount");

                    b.Property<bool>("InActivity");

                    b.Property<string>("Lastname");

                    b.Property<string>("Occupation");

                    b.Property<string>("Occupation_description");

                    b.Property<int?>("WorkscheduleID");

                    b.HasKey("VolunteerID");

                    b.HasIndex("AddressID");

                    b.HasIndex("AditionalinfoID");

                    b.HasIndex("ContactInformationID");

                    b.HasIndex("ContractID");

                    b.HasIndex("WorkscheduleID");

                    b.ToTable("Volunteer");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Workschedule", b =>
                {
                    b.Property<int>("WorkscheduleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommentsID");

                    b.Property<string>("HoursWeek");

                    b.HasKey("WorkscheduleID");

                    b.HasIndex("CommentsID");

                    b.ToTable("Workschedule");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Allocate", b =>
                {
                    b.HasOne("VolunteersEventsApp.Models.Event")
                        .WithMany("AllocatedVolunteer")
                        .HasForeignKey("EventID");

                    b.HasOne("VolunteersEventsApp.Models.Volunteer", "Volunteer")
                        .WithMany()
                        .HasForeignKey("VolunteerID");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Volunteer", b =>
                {
                    b.HasOne("VolunteersEventsApp.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("VolunteersEventsApp.Models.Aditionalinfo", "AditionalInfo")
                        .WithMany()
                        .HasForeignKey("AditionalinfoID");

                    b.HasOne("VolunteersEventsApp.Models.ContactInformation", "ContactInformation")
                        .WithMany()
                        .HasForeignKey("ContactInformationID");

                    b.HasOne("VolunteersEventsApp.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractID");

                    b.HasOne("VolunteersEventsApp.Models.Workschedule", "Workschedule")
                        .WithMany()
                        .HasForeignKey("WorkscheduleID");
                });

            modelBuilder.Entity("VolunteersEventsApp.Models.Workschedule", b =>
                {
                    b.HasOne("VolunteersEventsApp.Models.Comments", "Comments")
                        .WithMany()
                        .HasForeignKey("CommentsID");
                });
#pragma warning restore 612, 618
        }
    }
}
