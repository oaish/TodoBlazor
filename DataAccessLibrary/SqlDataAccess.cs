using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataAccessLibrary;
public class SqlDataAccess : ISqlDataAccess
{
    SqlConnection Sql { get; set; }
    public SqlDataAccess(IConfiguration config)
    {
        Sql = new SqlConnection(config.GetConnectionString("Todo"));
    }

    public async Task<IEnumerable<T>> FetchDataAsync<T, U>(string storedProcedure, U parameters)
    {
        var output = await Sql.QueryAsync<T>(storedProcedure, parameters, commandType: System.Data.CommandType.StoredProcedure);
        return output;
    }

    public async Task SaveDataAsync<T>(string storedProcedure, T parameters)
    {
        await Sql.QueryAsync<T>(storedProcedure, parameters, commandType: System.Data.CommandType.StoredProcedure);
    }
}
