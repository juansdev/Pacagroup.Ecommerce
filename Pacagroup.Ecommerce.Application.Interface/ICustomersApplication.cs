using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.CrossSectional.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion
        #region Async Methods
        Task<Response<bool>>  InsertAsync(CustomersDto customersDto);
        Task<Response<bool>> UpdateAsync(CustomersDto customersDto);
        Task<Response<bool>> DeleteAsync(String customerId);
        Task<Response<CustomersDto>> GetAsync(String customerId);
        Task<Response<IEnumerable<CustomersDto>>> GetAllAsync();
        #endregion
    }
}
