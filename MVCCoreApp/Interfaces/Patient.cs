using Dapper.Contrib.Extensions;
using MVCCoreApp.Models;

namespace MVCCoreApp.Interfaces
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
