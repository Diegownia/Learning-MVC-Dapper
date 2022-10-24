using MVCCoreApp.Interfaces;

namespace MVCCoreApp.Models
{
    public abstract class BaseModel : IBaseModel
    {
        public int Id { get; set; }
    }
}
