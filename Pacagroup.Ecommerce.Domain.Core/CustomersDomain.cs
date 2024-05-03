using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infrastructure.Interface;

namespace Pacagroup.Ecommerce.Domain.Core
{
    public class CustomersDomain : ICustomersDomain
    {
        private readonly ICustomersRepository _customersRepository;
        public CustomersDomain(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }
        #region Sync Methods
        public bool Delete(string customerId)
        {
            return _customersRepository.Delete(customerId);
        }

        public Customers Get(string customerId)
        {
            return _customersRepository.Get(customerId);
        }

        public IEnumerable<Customers> GetAll()
        {
            return _customersRepository.GetAll();
        }

        public bool Insert(Customers customer)
        {
            return _customersRepository.Insert(customer);
        }

        public bool Update(Customers customer)
        {
            return _customersRepository.Update(customer);
        }

        #endregion

        #region Async Methods

        public Task<bool> DeleteAsync(string customerId)
        {
            return _customersRepository.DeleteAsync(customerId);
        }

        public Task<IEnumerable<Customers>> GetAllAsync()
        {
            return _customersRepository.GetAllAsync();
        }

        public Task<Customers> GetAsync(string customerId)
        {
            return _customersRepository.GetAsync(customerId);
        }

        public Task<bool> InsertAsync(Customers customer)
        {
            return _customersRepository.InsertAsync(customer);
        }

        public Task<bool> UpdateAsync(Customers customer)
        {
            return _customersRepository.UpdateAsync(customer);
        }

        #endregion
    }
}
