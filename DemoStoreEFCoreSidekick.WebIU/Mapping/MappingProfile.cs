using AutoMapper;

namespace DemoStoreEFCoreSidekick.WebIU.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, ResultEmployeeDTO>().ReverseMap();
            CreateMap<Employee, CreateEmployeeDTO>().ReverseMap();
        }
    }
}
