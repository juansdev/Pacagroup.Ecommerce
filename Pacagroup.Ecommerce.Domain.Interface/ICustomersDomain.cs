using Pacagroup.Ecommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Domain.Interface
{
    public interface ICustomersDomain
    {
        #region Sync Methods
        bool Insert(Customers customer);
        bool Update(Customers customer);
        bool Delete(String customerId);
        Customers Get(String customerId);
        IEnumerable<Customers> GetAll();
        IEnumerable<Customers> GetAllWithPagination(int pageNumber, int pageSize);
        int Count();
        #endregion
        #region Async Methods
        Task<bool> InsertAsync(Customers customer);
        Task<bool> UpdateAsync(Customers customer);
        Task<bool> DeleteAsync(String customerId);
        Task<Customers> GetAsync(String customerId);
        Task<IEnumerable<Customers>> GetAllAsync();
        Task<IEnumerable<Customers>> GetAllWithPaginationAsync(int pageNumber, int pageSize);
        Task<int> CountAsync();
        #endregion
    }
}
