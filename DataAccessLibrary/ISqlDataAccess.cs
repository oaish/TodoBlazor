
namespace DataAccessLibrary;

public interface ISqlDataAccess
{
    Task<IEnumerable<T>> FetchDataAsync<T, U>(string storedProcedure, U parameters);
    Task SaveDataAsync<T>(string storedProcedure, T parameters);
}