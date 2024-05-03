using Microsoft.Extensions.Configuration;
using Pacagroup.Ecommerce.CrossSectional.Common;
using System.Data;
using System.Data.SqlClient;

namespace Pacagroup.Ecommerce.Infrastruture.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;
        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;
                sqlConnection.ConnectionString = _configuration.GetConnectionString("NorthwindConnection");
                sqlConnection.Open();
                return sqlConnection;
            }
        }
        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
