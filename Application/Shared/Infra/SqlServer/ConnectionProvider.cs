using Microsoft.Extensions.Configuration;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Shared.Infra.SqlServer
{
    public class ConnectionProvider : IConnectionProvider
    {
        private const string _sqlConfigurationPath = "SqlServerConfiguration:ConnectionString";
        private string _connectionString;

        public ConnectionProvider(IConfiguration configuration)
        {
            _connectionString = configuration[_sqlConfigurationPath];

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new ArgumentException();
            }
        }

        public async Task<IDbConnection> GetConnectionAsync(CancellationToken cancellationToken)
        {
            var sqlConnection = new SqlConnection(_connectionString);

            await sqlConnection.OpenAsync(cancellationToken);

            return sqlConnection;
        }
    }
}