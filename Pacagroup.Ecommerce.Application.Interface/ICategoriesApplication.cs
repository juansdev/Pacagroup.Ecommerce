using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.CrossSectional.Common;

namespace Pacagroup.Ecommerce.Application.Interface
{
    public interface ICategoriesApplication
    {
        Task<Response<IEnumerable<CategoriesDto>>> GetAll();
    }
}
