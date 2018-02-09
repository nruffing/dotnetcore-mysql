using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace DotNetCoreMySql.Dao.Builder
{
    public interface IDataAccessBuilderCommand
    {
        IDataAccessBuilderCommand WithInputParameter(string parameterName, MySqlDbType type, object value);

        IDataAccessBuilderCommand WithOutputParameter(string parameterName, MySqlDbType type, object value);

        Task ExecuteNonQueryAsync();

        Task<object> ExecuteScalarAsync();

        Task<DbDataReader> ExecuteReaderAsync();
    }
}
