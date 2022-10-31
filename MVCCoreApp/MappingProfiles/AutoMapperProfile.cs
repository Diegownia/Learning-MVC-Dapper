using AutoMapper;
using MVCCoreApp.Models;
using MVCCoreApp.ViewModels;

namespace MVCCoreApp.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Visit, VisitViewModel>().ReverseMap();
            //CreateMap<VisitViewModel, Visit>();
        }
    }
}
