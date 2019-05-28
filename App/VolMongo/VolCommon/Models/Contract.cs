using System;
using System.ComponentModel.DataAnnotations;

namespace VolCommon
{
    public class Contract
    {
        public bool HasContract { get; set; }
        public int NumberOfRegistration { get; set; }
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
    }
}