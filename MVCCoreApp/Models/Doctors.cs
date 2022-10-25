using MVCCoreApp.Interfaces;

namespace MVCCoreApp.Models
{
    public class Doctors : BaseModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public TimeSpan WorkingHours { get; set; }
        public Specialisations? SpecialisationsId { get; set; }

    }
}
