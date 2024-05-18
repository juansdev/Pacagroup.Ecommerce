using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.CrossSectional.Common;

namespace Pacagroup.Ecommerce.Application.Interface
{
    public interface ICustomersApplication
    {
        #region Sync Methods
        Response<bool> Insert(CustomersDto customersDto);
        Response<bool> Update(CustomersDto customersDto);
        Response<bool> Delete(String customerId);
        Response<CustomersDto> Get(String customerId);
        Response<IEnumerable<CustomersDto>> GetAll();
        ResponsePagination<IEnumerable<CustomersDto>> GetAllWithPagination(int pageNumber, int pageSize);
        #endregion
        #region Async Methods
        Task<Response<bool>>  InsertAsync(CustomersDto customersDto);
        Task<Response<bool>> UpdateAsync(CustomersDto customersDto);
        Task<Response<bool>> DeleteAsync(String customerId);
        Task<Response<CustomersDto>> GetAsync(String customerId);
        Task<Response<IEnumerable<CustomersDto>>> GetAllAsync();
        Task<ResponsePagination<IEnumerable<CustomersDto>>> GetAllWithPaginationAsync(int pageNumber, int pageSize);
        #endregion
    }
}
