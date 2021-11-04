using System.Data;

namespace FluentDapperFxn.Data.Interface
{
    public interface ISQLDBContext
    {
        IDbConnection GetDbConnection();
    }
}
