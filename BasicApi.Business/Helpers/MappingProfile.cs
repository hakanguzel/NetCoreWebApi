using AutoMapper;
using BasicApi.Data.DataAccess;
using BasicApi.Data.DtoModels;

namespace BasicApi.Business.Helpers
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            //USER
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}
