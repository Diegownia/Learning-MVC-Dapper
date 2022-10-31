using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCoreApp.Interfaces;
using MVCCoreApp.Models;
using System.ComponentModel;

namespace MVCCoreApp.ViewModels
{
    public class VisitViewModel : IVisitViewModel
    {
        public DateTime VisitDate { get; set; }
        [DisplayName("Patient Details")]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public IEnumerable<SelectListItem>? Patients { get; set; }

    }
}
