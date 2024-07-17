using AutoMapper;
using Dadata.Model;
using TestProject.Model.Dto;

namespace TestProject
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Address, AddressDto>();
            CreateMap<Address, AddressDto>();
        }
    }
}
