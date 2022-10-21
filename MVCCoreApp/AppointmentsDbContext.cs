using System.Data;
using System.Data.SqlClient;

namespace MVCCoreApp
{
    public class AppointmentsDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public AppointmentsDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("sqlConnection");
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
