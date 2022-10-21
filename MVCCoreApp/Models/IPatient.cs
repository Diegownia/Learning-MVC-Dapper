namespace MVCCoreApp.Models
{
    public interface IPatient
    {
        string FullName { get; }
        DateTime? LastVisit { get; set; }
        string? Name { get; set; }
        DateTime? NextVisit { get; set; }
        string? Surname { get; set; }
    }
}