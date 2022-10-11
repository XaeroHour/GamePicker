using Dapper;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace SQLManager
{
    public class SQLConnector
    {
        public string ConnectionString { get; private set; }

        public SQLConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public async Task ExecuteStoredProcedureAsync(string storedProcedureName, DynamicParameters parameters)
        {
            await ExecuteStoredProcedureWithResult(storedProcedureName, parameters);
        }

        public async Task<SqlDataReader> ExecuteStoredProcedureWithResult(string storedProcedureName, DynamicParameters parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = storedProcedureName
                })
                {
                    cmd.Parameters.Add(parameters);
                    return await cmd.ExecuteReaderAsync();
                }
            }
        }
    }
}