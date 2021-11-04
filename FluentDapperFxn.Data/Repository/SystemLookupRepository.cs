using Dapper;
using FluentDapperFxn.Data.Interface;
using FluentDapperFxn.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace FluentDapperFxn.Data.Repository
{
   
    public class SystemLookupRepository : ISystemLookupRepository
    {
        private readonly ISQLDBContext _sqlDbContext;
        public SystemLookupRepository(ISQLDBContext sqlDbContext)
        {
            _sqlDbContext = sqlDbContext;
        }

        public async Task<List<SystemLookup>> GetAllSystemLookupCodes()
        {
            var dbConn = _sqlDbContext.GetDbConnection();

            var result = await dbConn.QueryAsync<SystemLookup>("select * from systemlookup").ConfigureAwait(false);

            return result.ToList();
        }

    }
}
