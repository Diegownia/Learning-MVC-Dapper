using Dapper.Contrib.Extensions;
using MVCCoreApp.Interfaces;

namespace MVCCoreApp.Models
{
    public abstract class BaseModel : IBaseModel
    {
        [Computed]
        public int Id { get; set; }
    }
}
