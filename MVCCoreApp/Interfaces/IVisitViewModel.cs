using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCoreApp.Models;

namespace MVCCoreApp.Interfaces
{
    public interface IVisitViewModel
    {
        int PatientId { get; set; }
        IEnumerable<SelectListItem>? Patients { get; set; }
        DateTime VisitDate { get; set; }
    }
}