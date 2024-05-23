using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.UseCases.Customers.Commands.CreateCustomerCommand;
using Pacagroup.Ecommerce.Application.UseCases.Customers.Commands.UpdateCustomerCommand;
using Pacagroup.Ecommerce.Domain.Entities;
using Pacagroup.Ecommerce.Domain.Events;

namespace Pacagroup.Ecommerce.Application.UseCases.Common.Mappings
{
    public class MapppingsProfile : Profile
    {
        public MapppingsProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Discount, DiscountDto>().ReverseMap();
            CreateMap<Discount, DiscountCreatedEvent>().ReverseMap();

            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
        }
    }
}
