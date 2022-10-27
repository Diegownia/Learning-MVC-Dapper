namespace MVCCoreApp.Models
{
    public class Visit : BaseModel
    {
        public DateTime VisitDate { get; set; }
        public int PatientId { get; set; }
    }
}
