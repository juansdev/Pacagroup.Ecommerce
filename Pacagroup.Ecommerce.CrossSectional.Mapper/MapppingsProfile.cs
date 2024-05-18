using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.CrossSectional.Mapper
{
    public class MapppingsProfile : Profile
    {
        public MapppingsProfile()
        {
            CreateMap<Customers, CustomersDto>().ReverseMap();
            CreateMap<Users, UsersDto>().ReverseMap();
            CreateMap<Categories, CategoriesDto>().ReverseMap();
        }
    }
}
