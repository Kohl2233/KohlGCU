using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace AppointmentScheduler.Models
{
    public class AppointmentModel
    {
        // Class Attributes
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's Full Name")]
        public string PatientName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Requested Appointment Date")]
        public DateTime dateTime { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Patients Approx. Net Worth")]
        public decimal PatientNetWorth {  get; set; }

        [Required]
        [DisplayName("Primary Doctor's Last Name")]
        public string DoctorName { get; set; }

        [Required]
        [Range(1,10)]
        [DisplayName("Patient's Percieved Level of Pain")]
        public int PainLevel { get; set; }

        // Parameterized Constructor
        public AppointmentModel(string PatientName, DateTime dateTime, decimal PatientNetWorth, string DoctorName, int PainLevel)
        {
            this.PatientName = PatientName;
            this.dateTime = dateTime;
            this.PatientNetWorth = PatientNetWorth;
            this.DoctorName = DoctorName;
            this.PainLevel = PainLevel;
        }

        // Default Constructor
        public AppointmentModel() { }
    }
}
