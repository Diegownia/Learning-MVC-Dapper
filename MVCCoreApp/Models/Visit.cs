using MVCCoreApp.Interfaces;

namespace MVCCoreApp.Models
{
    public class Visit : BaseModel, IVisit
    {
        public DateTime VisitDate { get; set; }
        public Patient? Patient { get; set; }
    }
}
