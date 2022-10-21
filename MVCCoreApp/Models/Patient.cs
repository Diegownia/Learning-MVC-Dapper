using Dapper.Contrib.Extensions;
using MVCCoreApp.Interfaces;

namespace MVCCoreApp.Models
{
    public class Patient : BaseModel, IPatient
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }

        [Computed]
        public string FullName
        {
            get => Name + Surname;
        }

        public DateTime? NextVisit { get; set; }

        public DateTime? LastVisit { get; set; }
    }
}
