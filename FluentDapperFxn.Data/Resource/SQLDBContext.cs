using FluentDapperFxn.Common.Interface;
using FluentDapperFxn.Data.Interface;
using System.Data;
using System.Data.SqlClient;

namespace FluentDapperFxn.Data.Resource
{
    public class SQLDBContext : ISQLDBContext
    {
        private readonly IAppSettingsService _appSettings;
        public SQLDBContext(IAppSettingsService appSettings)
        {
            _appSettings = appSettings;
        }

        public IDbConnection GetDbConnection()
        {
            IDbConnection dbConn = new SqlConnection(_appSettings.DBConnectionString);

            return dbConn;
        }
    }
}
