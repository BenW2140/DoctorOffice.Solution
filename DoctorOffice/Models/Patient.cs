using System.Collections.Generic;

namespace DoctorOffice.Models
{
  public class Patient
  {
    public Patient()
    {
      this.Doctors = new HashSet<DoctorPatient>();
    }

    public int PatientId { get; set; }
    public string Name { get; set; }
    public string Birthdate { get; set; }

    public ICollection<DoctorPatient> Doctors { get; }
  }
}