using FluentDapperFxn;
using FluentDapperFxn.Common;
using FluentDapperFxn.Data;
using FluentDapperFxn.Domain;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(DapperFluentFxnStartup))]
namespace FluentDapperFxn
{
    public class DapperFluentFxnStartup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.ConfigureCommon();
            builder.Services.ConfigureData();
            builder.Services.ConfigureDomain();
        }
    }
}
