using MVCCoreApp.Interfaces;

namespace MVCCoreApp.Models
{
    public class Doctors : BaseModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public TimeSpan WorkingHours { get; set; }

        //Relationships
        //Doctor can have multiple specialisations
        public IList<Specialisations>? Specialisations { get; set; }

        //Many to Many with Patient [special model to represent that relation was made]

        public IList<PatientDoctor>? DoctorPatient { get; set; }

    }
}
