namespace HospitalMVC.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Case { get; set; } = string.Empty;
        public int Age { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; } = null!;
        public DateTime FirstDate { get; set; } = DateTime.Now;
        

    }
}
