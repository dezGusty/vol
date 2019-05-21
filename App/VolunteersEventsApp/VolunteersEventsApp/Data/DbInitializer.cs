using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolunteersEventsApp.Models;

namespace VolunteersEventsApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any volunteer
            if (context.Volunteer.Any())
            {
                return;   // DB has been seeded
            }

            var volunteers = new Volunteer[]
            {
                new Volunteer { Firstname = "Andrei", Lastname = "Ionescu", Gender = Gender.M, Age = Int16.Parse("20"), Birthdate = DateTime.Parse("1.01.1999"), Desired_workplace = Desired_workplace.CANTINA, Field_of_activity = "bucatar", Occupation = "", Occupation_description = "", InActivity = bool.Parse("true"), HourCount = Int16.Parse("2") },
                new Volunteer { Firstname = "Andrei", Lastname = "Ionescu", Gender = Gender.M, Age = Int16.Parse("20"), Birthdate = DateTime.Parse("1.01.1999"), Desired_workplace = Desired_workplace.CANTINA, Field_of_activity = "bucatar", Occupation = "", Occupation_description = "", InActivity = bool.Parse("true"), HourCount = Int16.Parse("2") },
                new Volunteer { Firstname = "Andrei", Lastname = "Ionescu", Gender = Gender.M, Age = Int16.Parse("20"), Birthdate = DateTime.Parse("1.01.1999"), Desired_workplace = Desired_workplace.CANTINA, Field_of_activity = "bucatar", Occupation = "", Occupation_description = "", InActivity = bool.Parse("true"), HourCount = Int16.Parse("2") },
                new Volunteer { Firstname = "Maria", Lastname = "Tei", Gender = Gender.F, Age = Int16.Parse("30"), Birthdate = DateTime.Parse("29.02.1989"), Desired_workplace = Desired_workplace.EVENIMENTE, Field_of_activity = "doctor", Occupation = "", Occupation_description = "", InActivity = bool.Parse("false"), HourCount = Int16.Parse("0") },
                new Volunteer { Firstname = "Andrei", Lastname = "Ionescu", Gender = Gender.M, Age = Int16.Parse("20"), Birthdate = DateTime.Parse("1.01.1999"), Desired_workplace = Desired_workplace.CANTINA, Field_of_activity = "bucatar", Occupation = "", Occupation_description = "", InActivity = bool.Parse("true"), HourCount = Int16.Parse("2") },
                new Volunteer { Firstname = "Andrei", Lastname = "Ionescu", Gender = Gender.M, Age = Int16.Parse("20"), Birthdate = DateTime.Parse("1.01.1999"), Desired_workplace = Desired_workplace.CANTINA, Field_of_activity = "bucatar", Occupation = "", Occupation_description = "", InActivity = bool.Parse("true"), HourCount = Int16.Parse("2") },
                new Volunteer { Firstname = "Andrei", Lastname = "Ionescu", Gender = Gender.M, Age = Int16.Parse("20"), Birthdate = DateTime.Parse("1.01.1999"), Desired_workplace = Desired_workplace.CANTINA, Field_of_activity = "bucatar", Occupation = "", Occupation_description = "", InActivity = bool.Parse("true"), HourCount = Int16.Parse("2") },
                new Volunteer { Firstname = "Andrei", Lastname = "Ionescu", Gender = Gender.M, Age = Int16.Parse("20"), Birthdate = DateTime.Parse("1.01.1999"), Desired_workplace = Desired_workplace.CANTINA, Field_of_activity = "bucatar", Occupation = "", Occupation_description = "", InActivity = bool.Parse("true"), HourCount = Int16.Parse("2") },
                new Volunteer { Firstname = "Andrei", Lastname = "Ionescu", Gender = Gender.M, Age = Int16.Parse("20"), Birthdate = DateTime.Parse("1.01.1999"), Desired_workplace = Desired_workplace.CANTINA, Field_of_activity = "bucatar", Occupation = "", Occupation_description = "", InActivity = bool.Parse("true"), HourCount = Int16.Parse("2") },
                new Volunteer { Firstname = "Andrei", Lastname = "Ionescu", Gender = Gender.M, Age = Int16.Parse("20"), Birthdate = DateTime.Parse("1.01.1999"), Desired_workplace = Desired_workplace.CANTINA, Field_of_activity = "bucatar", Occupation = "", Occupation_description = "", InActivity = bool.Parse("true"), HourCount = Int16.Parse("2") }
        }; foreach (Volunteer v in volunteers)
            {
                context.Volunteer.Add(v);
            }
            context.SaveChanges();

            if (context.Contract.Any())
            {
                return;   // DB has been seeded
            }
            var  contracts = new Contract[]
            { new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
            new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
                new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
                new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
                new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
                new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
                new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
                new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
                new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
                new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") },
                new Contract { HasContract = bool.Parse("true"), ContractPeriod = Int16.Parse("12"), NumberOfRegistration = Int16.Parse("12/1345") }
                };
            foreach (Contract c in contracts)
            {
                context.Contract.Add(c);
            }
            context.SaveChanges();


            if (context.Address.Any())
            {
                return;   // DB has been seeded
            }
            var address = new Address[]
            {
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },
                new Address { City = "Brasov", Country = "Romania", Number = "2", Street = "Str. Toamnei" },

            };
            foreach (Address a in address)
            {
                context.Address.Add(a);
            }
            context.SaveChanges();


            if (context.Contract.Any())
            {
                return;   // DB has been seeded
            }

            var aditionalinfos = new Aditionalinfo[]
            {
                new Aditionalinfo {HasDrivingLicence =bool.Parse("true"),HasCar =bool.Parse("true") },
                
                }; foreach (Aditionalinfo b in aditionalinfos)
            {
                context.Aditionalinfo.Add(b);
            }
            context.SaveChanges();

        }
    }
}

