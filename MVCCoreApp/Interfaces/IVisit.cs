using MVCCoreApp.Models;

namespace MVCCoreApp.Interfaces
{
    public interface IVisit : IBaseModel
    {
        int PatientId { get; set; }
        DateTime VisitDate { get; set; }
    }
}