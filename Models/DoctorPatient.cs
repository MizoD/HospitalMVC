namespace HospitalMVC.Models
{
    public class DoctorPatient
    {
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public Doctor Doctor { get; set; } = null!;
        public Patient Patient { get; set; } = null!;
    }
}
