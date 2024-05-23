using Pacagroup.Ecommerce.Domain.Entities;

namespace Pacagroup.Ecommerce.Application.Interface.Persistence
{
    public interface IUsersRepository
    {
        Task<User> Authenticate(string username, string password);

    }
}
