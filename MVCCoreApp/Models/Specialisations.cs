using Dapper.Contrib.Extensions;

namespace MVCCoreApp.Models
{
    [Table ("Specialisations")] // otherwise dapper will be looking for 'Specialisationss'
    public class Specialisations : BaseModel
    {
        public string? Specialisation { get; set; }
        public string? CertifyingBody { get; set; }
    }
}
