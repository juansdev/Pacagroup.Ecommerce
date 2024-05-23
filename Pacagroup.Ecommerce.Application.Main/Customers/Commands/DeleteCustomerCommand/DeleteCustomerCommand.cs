using MediatR;
using Pacagroup.Ecommerce.CrossSectional.Common;

namespace Pacagroup.Ecommerce.Application.UseCases.Customers.Commands.DeleteCustomerCommand
{
    public sealed record DeleteCustomerCommand : IRequest<Response<bool>>
    {
        public string CustomerId { get; set; }
    }
}
