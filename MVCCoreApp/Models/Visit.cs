using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCoreApp.Interfaces;

namespace MVCCoreApp.Models
{
    public class Visit : BaseModel, IVisit
    {
        public DateTime VisitDate { get; set; }
        public int PatientId { get; set; }
    }
}
