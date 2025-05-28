namespace HospitalMVC.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Age { get; set; }
        public bool Avilable { get; set; }
        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();

    }
}
