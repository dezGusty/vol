using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Collections;
using MongoDB.Driver;

namespace SiemensProject
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    using System.Collections;
    using MongoDB.Driver;
    class Db
    {

        public static void Showalljson()//Nu Functioneza nu stiu de ce dar oricum nu e nevoie de el daca merge show all volunteers
        {
            Volunteer ble = new Volunteer();
            string strResultJson = JsonConvert.SerializeObject(ble);
            strResultJson = String.Empty;
            strResultJson = File.ReadAllText(@"volunteer.json");
            var dictionary = JsonConvert.DeserializeObject<IDictionary>(strResultJson);
            foreach (DictionaryEntry entry in dictionary)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }

        public static int Idgetter(List<Volunteer> allvolunteers2)//Returneaza cel mai mare id dintre toate voluntari (este folosit cand creeam un nou voluntar si mai incrementam aceasta valoare)
        {
            var vols = allvolunteers2.AsQueryable<Volunteer>().ToList();
            int nrofvols = 0;
            foreach (var volunteer in vols)
            {
                nrofvols = volunteer.id;
            }
            return nrofvols;
        }
        public static int Idgetter_e(List<Event> allevents)
        {
            var new_events = allevents.AsQueryable<Event>().ToList();
            int nrofvols_e = 0;
            foreach (var Event in new_events)
            {
                nrofvols_e = Event.Id_Event;
            }
            return nrofvols_e;
        }
        internal static Event AddEventFromKeyboard()
        {
            Event new_event = new Event();
            Console.WriteLine("You have chosen to add an Event");
            Console.WriteLine("Please enter the event:");
            Console.WriteLine("Name Of Event: ");
            new_event.NameOfEvent = Console.ReadLine();
            Console.WriteLine("Tipe of Event: ");
            new_event.TipeOfEvent = Console.ReadLine();
            Console.WriteLine("Place of Event:");
            new_event.PlaceOfEvent = Console.ReadLine();
           
            do
            {
                try
                {
                    new_event.Lasting = 0;
                    Console.WriteLine("Lasting: ");
                    new_event.Lasting = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a Number");
                    new_event.Lasting = 0;
                }

            } while (new_event.Lasting  < 1);
         
            do
            {
                try
                {
                    new_event.NumberOfVolunteersNeeded = 0;
                    Console.WriteLine("Number Of Volunteers Needed:");
                    new_event.NumberOfVolunteersNeeded = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a Number");
                    new_event.NumberOfVolunteersNeeded = 0; ;
                }

            } while (new_event.NumberOfVolunteersNeeded < 1);
            Console.WriteLine("Type Of Activities:");
            new_event.TipeOfActyvities = Console.ReadLine();

            do
            {
                try
                {
                    new_event.dateOfEvent.Year = 0;
                    Console.WriteLine("Year: ");
                    new_event.dateOfEvent.Year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a Number");
                    new_event.dateOfEvent.Year = 0;
                }

            } while (new_event.dateOfEvent.Year < 1);
            do
            {
                try
                {
                    new_event.dateOfEvent.Month = 0;
                    Console.WriteLine("Month: ");
                    new_event.dateOfEvent.Month = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a Number");
                    new_event.dateOfEvent.Month = 0;
                }

            } while (new_event.dateOfEvent.Month < 1);//int pentru brthmonth
            do
            {
                try
                {
                    new_event.dateOfEvent.Day = 0;
                    Console.WriteLine("Day: ");
                    new_event.dateOfEvent.Day = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a Number");
                    new_event.dateOfEvent.Day = 0;
                }

            } while (new_event.dateOfEvent.Day < 1);



            Console.WriteLine("Event successfully added!");

            return new_event;




        }
        internal static Volunteer AddVolunteerfromCmd()//Aici se creaza un nou voluntar de la tastatura
        {
            Volunteer vol = new Volunteer();
            Console.WriteLine("You have chosen to add a Volunteer");
            Console.WriteLine("Please enter the persons:");
            Console.WriteLine("Firstname: ");
            vol.Firstname = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            vol.Lastname = Console.ReadLine();
            do
            {
                try
                {
                    vol.Age = 0;
                    Console.WriteLine("Age: ");
                    vol.Age = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a Number");
                    vol.Age = 0;
                }

            } while (vol.Age < 1);// int  pentru age
            Console.WriteLine("Country: ");
            vol.Address.Country = Console.ReadLine();
            Console.WriteLine("City: ");
            vol.Address.City = Console.ReadLine();
            Console.WriteLine("Street: ");
            vol.Address.Street = Console.ReadLine();
            Console.WriteLine("Number: ");
            vol.Address.Number = Console.ReadLine();
            Console.WriteLine("Gender: ");
            vol.Gender = Console.ReadLine();
            do
            {
                try
                {
                    vol.birthdate.Year = 0;
                    Console.WriteLine("Birth Year: ");
                    vol.birthdate.Year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a Number");
                    vol.birthdate.Year = 0;
                }

            } while (vol.birthdate.Year < 1);//int pentru brthyear
            do
            {
                try
                {
                    vol.birthdate.Month = 0;
                    Console.WriteLine("Birth Month: ");
                    vol.birthdate.Month = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a Number");
                    vol.birthdate.Month = 0;
                }

            } while (vol.birthdate.Month < 1);//int pentru brthmonth
            do
            {
                try
                {
                    vol.birthdate.Day = 0;
                    Console.WriteLine("Birth Day: ");
                    vol.birthdate.Day = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a Number");
                    vol.birthdate.Day = 0;
                }

            } while (vol.birthdate.Day < 1);

            bool aux = false;
            do
            {
                try
                {
                    vol.aditionalInfo.HasDrivingLicence = false;

                    Console.WriteLine("Has driving license?(true/false)");

                    vol.aditionalInfo.HasDrivingLicence = Convert.ToBoolean(Console.ReadLine());
                    aux = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter true/false;");
                    
                }

            } while (aux != true);
           

            aux = false;
            do
            {
                try
                {
                    vol.aditionalInfo.HasCar = false;

                    Console.WriteLine("Has a car?(true/false)");

                    vol.aditionalInfo.HasCar = Convert.ToBoolean(Console.ReadLine());
                    aux = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter true/false;");
                   
                }

            } while (aux != true);


            Console.WriteLine("EmailAddress: : ");
            vol.ContactInformations.MailAdress = Console.ReadLine();
            Console.WriteLine("PhoneNumber: : ");
            vol.ContactInformations.PhoneNumber = Console.ReadLine();
           
            aux = false;
            do
            {
                try
                {
                    vol.contract.HasContract= false;

                    Console.WriteLine("Has contract?(true/false)");

                    vol.contract.HasContract = Convert.ToBoolean(Console.ReadLine());
                    aux = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter true/false;");

                }

            }  while (aux != true) ;


            Console.WriteLine("Contract Period in months");
            vol.Contract.ContractPeriod = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Number of Registration: : ");
            vol.Contract.NumberOfRegistration = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Registration Year");
            vol.registrationday.Year = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Registration Month");
            vol.registrationday.Month = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Registration Day");
            vol.registrationday.Day = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Desired Workplace");
            vol.Desired_workplace = Console.ReadLine();
            Console.WriteLine("Field of activity");
            vol.Field_of_activity = Console.ReadLine();
            Console.WriteLine("Hour Count");
            vol.HourCount = Convert.ToInt16(Console.ReadLine());
           
             aux = false;
            do
            {
                try
                {
                    vol.InActivity= false;

                    Console.WriteLine("Is active?(true/false)");

                    vol.InActivity = Convert.ToBoolean(Console.ReadLine());
                    aux = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter true/false;");

                }

            } while (aux != true);



            Console.WriteLine("Occupation");
            vol.Occupation = Console.ReadLine();
            Console.WriteLine("Occupation Description");
            vol.Occupation_description = Console.ReadLine();
            Console.WriteLine("How many Hours a week");
            vol.WorkSchedule.HoursWeek = Console.ReadLine();
            Console.WriteLine("Which days is he available");
            vol.WorkSchedule.Comments.Days = Console.ReadLine();
            Console.WriteLine("What hours is he available");
            vol.WorkSchedule.Comments.TimeAvailability = Console.ReadLine();

            Console.WriteLine("Volunteer successfully added!");

            return vol;
        }

        internal static void Edit(List<Volunteer> allvolunteers2, int z)
        {

        }//Aici Mai Trebuie de lucrat, dar fa tu sa nu zici ca fac eu tot si este si destul de greu

        internal static void ShowVolunteerbd(List<Volunteer> allvolunteers2)//Este Facut Blana pentru toate cazurile si din ianuarie si la sfarsitul lui decembrie
        {
            string todaydate = DateTime.Today.ToString("dd-MM-yyyy");
            string[] dates = todaydate.Split("-");
            int Day = Convert.ToInt16(dates[0]);
            int Month = Convert.ToInt16(dates[1]);
            int Year = Convert.ToInt16(dates[2]);
            /*Day = 28;
            Month = 12;
            Year = 2019;*/
            Day = (Month - 1) * 30 + Day;
            int voldays;

            Console.WriteLine("The following Volunteers are going to have birthdays");
            foreach (Volunteer vol in allvolunteers2)
            {
                voldays = (vol.birthdate.Month - 1) * 30 + vol.birthdate.Day;

                if ((Day <= voldays && Day + 7 > voldays) || (Day > 354 && 362 - Day >= voldays))//mai trebe aici caz special cand este decembrie 20 - ianuarie 7
                {
                    Console.WriteLine(vol.Firstname + " " + vol.Lastname + " : " + vol.birthdate.Year + "." + vol.birthdate.Month + "." + vol.birthdate.Day);
                }

            }
        }

        internal static void ShowVolunteercontractexp(List<Volunteer> allvolunteers2)
        {
            string todaydate = DateTime.Today.ToString("dd-MM-yyyy");
            string[] dates = todaydate.Split("-");
            int Day = Convert.ToInt16(dates[0]);
            int Month = Convert.ToInt16(dates[1]);
            int Year = Convert.ToInt16(dates[2]);
            Day = (Year - 2001) * 365 + (Month - 1) * 30 + Day;
            Console.WriteLine(Day);
            int volcontract;
            Console.WriteLine("The following Volunteers are going to have their contracts expire/or had expired in an interval of 30 days");
            foreach (Volunteer vol in allvolunteers2)
            {
                volcontract = (vol.registrationday.Year - 2001) * 365 + (vol.registrationday.Month - 1 + vol.Contract.ContractPeriod) * 30 + vol.birthdate.Day;
                if (vol.registrationday.Month + vol.Contract.ContractPeriod > 12)
                    volcontract = volcontract + 30;

                if (Day <= volcontract && Day + 30 > volcontract)
                {
                    if (vol.registrationday.Month + vol.Contract.ContractPeriod > 12)
                    {
                        Console.WriteLine("EXPIRING SOON!!!" + vol.Firstname + " " + vol.Lastname + " : " + (vol.registrationday.Year + 1) + "." + (vol.registrationday.Month + vol.Contract.ContractPeriod - 12) + "." + vol.registrationday.Day);
                    }
                    else
                    {
                        Console.WriteLine("EXPIRING SOON!!!" + vol.Firstname + " " + vol.Lastname + " : " + vol.registrationday.Year + "." + (vol.registrationday.Month + vol.Contract.ContractPeriod) + "." + vol.registrationday.Day);
                    }

                }
                else if (Day > volcontract && Day - 30 < volcontract)
                {
                    if (vol.registrationday.Month + vol.Contract.ContractPeriod > 12)
                    {
                        Console.WriteLine("EXPIRED RECENTLY!!" + vol.Firstname + " " + vol.Lastname + " : " + (vol.registrationday.Year + 1) + "." + (vol.registrationday.Month + vol.Contract.ContractPeriod - 12) + "." + vol.registrationday.Day);
                    }
                    else
                    {
                        Console.WriteLine("EXPIRED RECENTLY!!" + vol.Firstname + " " + vol.Lastname + " : " + vol.registrationday.Year + "." + (vol.registrationday.Month + vol.Contract.ContractPeriod) + "." + vol.registrationday.Day);
                    }
                }

            }
        }//Este facut si acesta

        internal static void Showallvolunteers(List<Volunteer> allvolunteers2)
        {
            foreach (Volunteer vol in allvolunteers2)
            {
                Console.WriteLine("Id: " + vol.id);
                Console.WriteLine("Firstname: " + vol.Firstname);
                Console.WriteLine("Lastname: " + vol.Lastname);
                Console.WriteLine("Age: " + vol.Age);
                Console.WriteLine("Address: " + vol.Address.Country + "," + vol.Address.City + "," + vol.Address.Street + "" + vol.Address.Number);
                Console.WriteLine("Aditionalinfo: " + vol.AditionalInfo.HasDrivingLicence + "," + vol.AditionalInfo.HasDrivingLicence);
                Console.WriteLine("Gender: " + vol.Gender);
                Console.WriteLine("BirthDate : " + vol.birthdate.Day + "/" + vol.birthdate.Month + "/" + vol.birthdate.Year);
                Console.WriteLine("Registrationday: " + vol.registrationday.Day + "/" + vol.registrationday.Month + "/" + vol.registrationday.Year);
                Console.WriteLine("Contract information: " + vol.contract.HasContract + "," + vol.contract.ContractPeriod + "," + vol.contract.NumberOfRegistration);
                Console.WriteLine("Desired workplace: " + vol.Desired_workplace);
                Console.WriteLine("Field_of_activity: " + vol.Field_of_activity);
                Console.WriteLine("HourCount: " + vol.HourCount);
                Console.WriteLine("Is InActivity: " + vol.InActivity);
                Console.WriteLine("Occupation: " + vol.Occupation);
                Console.WriteLine("Occupation_description : " + vol.Occupation_description);
                Console.WriteLine("workSchedule: hours/day " + vol.workSchedule.HoursWeek + ", days/week " + vol.workSchedule.Comments.Days);
                Console.WriteLine("Contact Informations" + vol.ContactInformations.PhoneNumber + "," + vol.ContactInformations.MailAdress);
                Console.WriteLine(" Comments:" + vol.comments.Days + "," + vol.comments.TimeAvailability);
                Console.WriteLine("-----------------------------------------------------");

            }
        }

        internal static void ShowallvolunteersEvent(List<Event> allevents)
        {
            foreach (Event new_event in allevents)
            {
                Console.WriteLine("Id:" + new_event.Id_Event);
                Console.WriteLine("Name Of Event: " + new_event.NameOfEvent);
                Console.WriteLine("Place Of Event" + new_event.PlaceOfEvent);
                Console.WriteLine("Date Of Event:" + new_event.dateOfEvent.Year+"/"+new_event.dateOfEvent.Month+"/"+new_event.dateOfEvent.Day);
                Console.WriteLine("Lasting (in days):" + new_event.Lasting);
                Console.WriteLine("Number Of Volunteers Needed:" + new_event.NumberOfVolunteersNeeded);
                Console.WriteLine("Type Of Activities :" + new_event.TipeOfActyvities);
                Console.WriteLine("Type Of Event:" + new_event.TipeOfEvent);
                Console.WriteLine("---------------------------------------------------------");
            }
        }

        internal static void SavetoJson(List<Volunteer> allvolunteers2)//aici trece toate datele din arrayul allvollunteers in fisierul Json
        {

            int countid = 1;
            foreach (Volunteer vol in allvolunteers2)
            {               
                countid=vol.id;
            }
            foreach (Volunteer vol in allvolunteers2)
            {
                string volstring = Convert.ToString(vol.id);
                if(volstring == "")
                {
                    vol.id = countid++;
                }
            }
                string tojson = JsonConvert.SerializeObject(allvolunteers2);
            if (tojson[0] == '[')
            {
                File.WriteAllText(@"..\..\..\data\event.json", tojson);
            }
            else
            {
                File.WriteAllText(@"..\..\..\data\event.json", "[");
                File.AppendAllText(@"..\..\..\data\event.json", tojson);
                File.AppendAllText(@"..\..\..\data\event.json", "]");
            }


        }

        internal static void SavetoJson_Event(List<Event> allevents)//aici trece toate datele din arrayul  allevents in fisierul Json
        {
            
            int countid = 1;
            string volstring;
            foreach (Event new_event in allevents)
            {
                countid = new_event.Id_Event;
            }
            foreach (Event new_event in allevents)
            {
                volstring = Convert.ToString(new_event.Id_Event);
                if (volstring == "")
                {
                    new_event.Id_Event = countid++;
                }
            }

            string tojson_e = JsonConvert.SerializeObject(allevents);
            if (tojson_e[0] == '[')
            {
                File.WriteAllText(@"..\..\..\data\event.json", tojson_e);
            }
            else
            {
                File.WriteAllText(@"..\..\..\data\event.json", "[");
                File.AppendAllText(@"..\..\..\data\event.json", tojson_e);
                File.AppendAllText(@"..\..\..\data\event.json", "]");
            }

        }

        internal static int Selector(List<Volunteer> allvolunteers2)//aici selectezi care persoana vei modifica mai incolo
        {
            int nr = 0;
            int idselected = 0;
            foreach (Volunteer vol in allvolunteers2)
            {
                nr++;
                Console.WriteLine("ID: " + nr + ", Name:" + vol.Firstname + " " + vol.Lastname);
            }
            Console.WriteLine("Please enter the number of which Person you want to edit/remove!");
            bool done = false;
            while (done == false)
            {
                idselected = Convert.ToInt16(Console.ReadLine());
                if (idselected > nr || idselected <= 0)
                {
                    Console.WriteLine("Not a valid id number!\n Please enter another id!");
                }
                else
                {
                    done = true;
                }
            }
            return idselected - 1;
        }
        internal static int Selector_Event(List<Event> allevents)//aici selectezi care persoana vei modifica mai incolo
        {
            int nr_e = 0;
            int idselected_e = 0;
            foreach (Event new_event in allevents)
            {
                nr_e++;
                Console.WriteLine("Number: " + nr_e + ", NameOfEvent:" + new_event.NameOfEvent);
            }
            Console.WriteLine("Please enter the number of the Event you want to edit/remove!");
            bool done_e = false;
            while (done_e == false)
            {
                idselected_e = Convert.ToInt16(Console.ReadLine());
                if (idselected_e > nr_e || idselected_e <= 0)
                {
                    Console.WriteLine("Not a valid id number!\n Please enter another id!");
                }
                else
                {
                    done_e = true;
                }
            }
            return idselected_e - 1;
        }
    }
}