using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infrastructure.Interface;

namespace Pacagroup.Ecommerce.Domain.Core
{
    public class CustomersDomain : ICustomersDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomersDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #region Sync Methods
        public bool Delete(string customerId)
        {
            return _unitOfWork.Customers.Delete(customerId);
        }

        public Customers Get(string customerId)
        {
            return _unitOfWork.Customers.Get(customerId);
        }

        public IEnumerable<Customers> GetAll()
        {
            return _unitOfWork.Customers.GetAll();
        }

        public bool Insert(Customers customer)
        {
            return _unitOfWork.Customers.Insert(customer);
        }

        public bool Update(Customers customer)
        {
            return _unitOfWork.Customers.Update(customer);
        }

        public IEnumerable<Customers> GetAllWithPagination(int pageNumber, int pageSize)
        {
            return _unitOfWork.Customers.GetAllWithPagination(pageNumber, pageSize);
        }

        public int Count()
        {
            return _unitOfWork.Customers.Count();
        }

        #endregion

        #region Async Methods

        public Task<bool> DeleteAsync(string customerId)
        {
            return _unitOfWork.Customers.DeleteAsync(customerId);
        }

        public Task<IEnumerable<Customers>> GetAllAsync()
        {
            return _unitOfWork.Customers.GetAllAsync();
        }

        public Task<Customers> GetAsync(string customerId)
        {
            return _unitOfWork.Customers.GetAsync(customerId);
        }

        public Task<bool> InsertAsync(Customers customer)
        {
            return _unitOfWork.Customers.InsertAsync(customer);
        }

        public Task<bool> UpdateAsync(Customers customer)
        {
            return _unitOfWork.Customers.UpdateAsync(customer);
        }

        public Task<IEnumerable<Customers>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            return _unitOfWork.Customers.GetAllWithPaginationAsync(pageNumber, pageSize);
        }

        public Task<int> CountAsync()
        {
            return _unitOfWork.Customers.CountAsync();
        }

        #endregion
    }
}
