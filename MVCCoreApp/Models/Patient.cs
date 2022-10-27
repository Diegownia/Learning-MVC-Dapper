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
        public IList<Visit>? Visits { get; set; }

        public IList<PatientDoctor>? PatientDoctors { get; set; }

    }
}
