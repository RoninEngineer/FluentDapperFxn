using Dapper;
using FluentDapperFxn.Common.Consts;
using FluentDapperFxn.Common.Interface;
using FluentValidation;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FluentDapperFxn.Domain.Dto
{
    public class SystemLookup
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public bool Active { get; set; }
    }

    public class SystemLookupValidator : AbstractValidator<SystemLookup>
    {
        private IAppSettingsService _appsettings;
        public SystemLookupValidator(IAppSettingsService appsettings)
        {
            _appsettings = appsettings;
            RuleFor(x => x.Code).NotNull().Must(BeUnique);
            RuleFor(x => x.Description).NotNull();
            RuleFor(x => x.Value).NotNull();
            RuleFor(x => x.Active).NotNull();
        }

        private bool BeUnique(string code)
        {
            IDbConnection dbConn = new SqlConnection(_appsettings.DBConnectionString);
            var parameters = new { Code = code };
            var sql = "select 1 from SystemLookup where Code = @Code";
           
            var result = dbConn.QuerySingleOrDefault(sql, parameters);
            if(result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
