using Pacagroup.Ecommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Infrastructure.Interface
{
    public interface ICustomersRepository
    {
        #region Sync Methods
        bool Insert(Customers customer);
        bool Update(Customers customer);
        bool Delete(String customerId);
        Customers Get(String customerId);
        IEnumerable<Customers> GetAll();
        #endregion
        #region Async Methods
        Task<bool> InsertAsync(Customers customer);
        Task<bool> UpdateAsync(Customers customer);
        Task<bool> DeleteAsync(String customerId);
        Task<Customers> GetAsync(String customerId);
        Task<IEnumerable<Customers>> GetAllAsync();
        #endregion
    }
}
