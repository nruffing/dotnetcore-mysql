using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace DotNetCoreMySql.Dao.Builder
{
    public class DataAccessBuilderCommand : IDataAccessBuilderCommand
    {
        #region Private Members

        MySqlCommand _command;

        #endregion

        #region Construction

        public DataAccessBuilderCommand(MySqlCommand command)
        {
            _command = command;
        }

        #endregion

        #region IDataAccessBuildCommand Implementation

        public IDataAccessBuilderCommand WithInputParameter(string parameterName, MySqlDbType type, object value)
        {
            MySqlParameter parameter = new MySqlParameter(parameterName, type);
            parameter.Value = value;
            parameter.Direction = ParameterDirection.Input;
            _command.Parameters.Add(parameter);

            return this;
        }

        public IDataAccessBuilderCommand WithOutputParameter(string parameterName, MySqlDbType type, object value)
        {
            MySqlParameter parameter = new MySqlParameter(parameterName, type);
            parameter.Direction = ParameterDirection.Output;
            _command.Parameters.Add(parameter);

            return this;
        }

        public async Task ExecuteNonQueryAsync()
        {
            await _command.ExecuteNonQueryAsync();
        }

        public async Task<DbDataReader> ExecuteReaderAsync()
        {
            return await _command.ExecuteReaderAsync();
        }

        public async Task<object> ExecuteScalarAsync()
        {
            return await _command.ExecuteScalarAsync();
        }

        #endregion
    }
}
