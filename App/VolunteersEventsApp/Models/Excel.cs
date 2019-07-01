using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace VolunteersEventsApp.Models
{
    public class Excel
    {
        string Path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public List<Volunteer> Volunteers { get; set; }
        public List<Event> Events { get; set; }

        public  Excel(string Path,int Sheet)
        {
            this.Path = Path;
            wb = excel.Workbooks.Open(Path);
           ws = (Worksheet)wb.Sheets["Sheet"];
        }

       public void WriteExcelVolunteer( IList<Volunteer> Volunteers)
        { 
            ws.Cells[1, 1] = "ID Voluntar";
            ws.Cells[1, 2]= "Prenume";
            ws.Cells[1, 3] = "Nume";
            ws.Cells[1, 4] = "Gen";
            ws.Cells[1, 5] = "Data nasterii";
            ws.Cells[1, 6] = "Activiatea dorita";
            ws.Cells[1, 7] = "Domeniul de activitate";
            ws.Cells[1, 8] = "Ocupatia";
            ws.Cells[1, 9] = "Descriere ocupatie";
            ws.Cells[1, 10]= "Este activ?";
            ws.Cells[1, 11] = "Ore la activ";
            ws.Cells[1, 12] = "Tara";
            ws.Cells[1, 13] = "Oras";
            ws.Cells[1, 14] = "Numarul ";
            ws.Cells[1, 15] = "Strada";
            ws.Cells[1, 16]= "Are permis?";
            ws.Cells[1, 17] = "Are masina";
            ws.Cells[1, 18] = "Numar de telefon";
            ws.Cells[1, 19] = "Adresa de email";
            ws.Cells[1, 20] = "Are contract?";
            ws.Cells[1, 21] = "Numarul de inregistrare al contractului";
            ws.Cells[1, 22] = "Data inregistrarii contractului";
            ws.Cells[1, 23] = "Data expirarii contractului";
            ws.Cells[1, 24] = "Ore/saptamana";
            ws.Cells[1, 25] = "Zilele";
            ws.Cells[1, 25] = "Intervalul orar";




            int i = 1;

                foreach (var volunteer in Volunteers)
            {
           

                    i++;
                ws.Cells[RowIndex: "A" + i.ToString()] = volunteer.VolunteerID;
                ws.Cells[RowIndex: "B" + i.ToString()] = volunteer.Firstname;
                ws.Cells[RowIndex: "C" + i.ToString()] = volunteer.Lastname;
                ws.Cells[RowIndex: "D" + i.ToString()] = volunteer.Gender;
                ws.Cells[RowIndex: "E" + i.ToString()] = volunteer.Birthdate;
                ws.Cells[RowIndex: "F" + i.ToString()] = volunteer.Desired_workplace;
                ws.Cells[RowIndex: "G" + i.ToString()]= volunteer.Field_of_activity;
                ws.Cells[RowIndex: "H" + i.ToString()] = volunteer.Occupation;
                ws.Cells[RowIndex: "I" + i.ToString()] = volunteer.Occupation_description;
                ws.Cells[RowIndex: "J" + i.ToString()] = volunteer.InActivity;
                ws.Cells[RowIndex: "K" + i.ToString()] = volunteer.HourCount;
                ws.Cells[RowIndex: "L" + i.ToString()] = volunteer.Address.Country+","+ volunteer.Address.City+","+volunteer.Address.Street+","+ volunteer.Address.Number;
                ws.Cells[RowIndex: "M" + i.ToString()] = volunteer.AditionalInfo.HasDrivingLicence;
                ws.Cells[RowIndex: "N" + i.ToString()] = volunteer.AditionalInfo.HasCar;
                ws.Cells[RowIndex: "O" + i.ToString()] = volunteer.ContactInformation.PhoneNumber;
                ws.Cells[RowIndex: "P" + i.ToString()] = volunteer.ContactInformation.MailAdress;
                ws.Cells[RowIndex: "Q" + i.ToString()] = volunteer.Contract.HasContract;
                ws.Cells[RowIndex: "R" + i.ToString()] = volunteer.Contract.NumberOfRegistration;
                ws.Cells[RowIndex: "S" + i.ToString()] = volunteer.Contract.RegistrationDate;
                ws.Cells[RowIndex: "T" + i.ToString()] = volunteer.Contract.ExpirationDate;
                ws.Cells[RowIndex: "U" + i.ToString()] = volunteer.Workschedule.HoursWeek;
                ws.Cells[RowIndex: "V" + i.ToString()] = volunteer.Workschedule.Comments.Days;
                ws.Cells[RowIndex: "W" + i.ToString()] = volunteer.Workschedule.Comments.TimeAvailability ;
               

             
            }
        }

        void SaveAsVolunteer(string PathVolunteer)
        {
            wb.SaveAs(PathVolunteer);
        }
    

    public void WriteExcelEvents(IList<Event>Events)
    {
        ws.Cells[1, 1] = "ID eveniment";
            ws.Cells[1, 2] = "Numele evenimentului";
            ws.Cells[1, 3] = "Locul evenimentului";
            ws.Cells[1, 4] = "Tipul";
            ws.Cells[1, 5] = "Tipul Activitatii";
            ws.Cells[1, 6] = "Data";
            ws.Cells[1, 7] = "Numarul de voluntari necesari";

            int j = 1;
                foreach (var events in Events)
            {
                j++;
                ws.Cells[RowIndex: "A" + j.ToString()] = events.ID;
                ws.Cells[RowIndex: "B" + j.ToString()] = events.NameOfEvent;
                ws.Cells[RowIndex: "C" + j.ToString()] = events.PlaceOfEvent;
                ws.Cells[RowIndex: "D" + j.ToString()] = events.TypeOfEvent;
                ws.Cells[RowIndex: "E" + j.ToString()] = events.TypeOfActivities;
                ws.Cells[RowIndex: "F" + j.ToString()] = events.DateOfEvents;
                ws.Cells[RowIndex: "G" + j.ToString()] = events.NumberOfVolunteersNeeded;
            }
            
        }

        public void SaveFile()
        {
            wb.Save();
        }

        public void SaveAsEvents(string Path)
        {
            wb.SaveAs(Path);
        }
    }
}
