using Dapper.Contrib.Extensions;
using MVCCoreApp.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCoreApp.Models
{
    public class Patient : BaseModel, IPatient
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }

        [Computed]
        public string FullName
        {
            get => Name + " " + Surname;
        }
        [Computed]
        public IList<Visit>? Visit { get; set; }
        [Computed]
        public IList<PatientDoctor>? PatientDoctors { get; set; }

    }
}
