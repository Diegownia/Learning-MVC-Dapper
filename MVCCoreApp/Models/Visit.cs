using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCoreApp.Interfaces;

namespace MVCCoreApp.Models
{
    public class Visit : BaseModel, IVisit
    {
        public DateTime VisitDate { get; set; }
        public Patient? Patient { get; set; }

        [Computed]
        public IEnumerable<SelectListItem>? Patients { get; set; }
    }
}
