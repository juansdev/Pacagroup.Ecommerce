using Dapper;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Infrastructure.Interface;
using Pacagroup.Ecommerce.Infrastruture.Data;
using System.Data;

namespace Pacagroup.Ecommerce.Infrastructure.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DapperContext _context;
        public UsersRepository(DapperContext context)
        {
            _context = context;
        }
        public Users Authenticate(string userName, string password)
        {
            using(var connection = _context.CreateConnection())
            {
                var query = "UsersGetByUserAndPassword";
                var parameters = new DynamicParameters();
                parameters.Add("UserName", userName);
                parameters.Add("Password", password);
                var user = connection.QuerySingle<Users>(query, parameters, commandType: CommandType.StoredProcedure);
                return user;
            }
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Users Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Users>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Users entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(Users entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Users entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
