using MVCCoreApp.Models;

namespace MVCCoreApp.Interfaces
{
    public interface IVisit
    {
        Patient? Patient { get; set; }
        DateTime VisitDate { get; set; }
    }
}