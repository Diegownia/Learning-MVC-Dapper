using MVCCoreApp.Models;

namespace MVCCoreApp.Interfaces
{
    public interface IPatient
    {
        string FullName { get; }
        string? Name { get; set; }
        string? Surname { get; set; }
        IList<Visit>? Visit { get; set; }
        IList<PatientDoctor>? PatientDoctors { get; set; }
    }
}