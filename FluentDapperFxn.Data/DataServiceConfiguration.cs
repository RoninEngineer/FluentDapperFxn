using FluentDapperFxn.Data.Interface;
using FluentDapperFxn.Data.Repository;
using FluentDapperFxn.Data.Resource;
using Microsoft.Extensions.DependencyInjection;

namespace FluentDapperFxn.Data
{
    public static class DataServiceConfiguration
    {
        public static void ConfigureData(this IServiceCollection services)
        {
            services.AddTransient<ISQLDBContext, SQLDBContext>();
            services.AddTransient<ISystemLookupRepository, SystemLookupRepository>();

        }
    }
}
