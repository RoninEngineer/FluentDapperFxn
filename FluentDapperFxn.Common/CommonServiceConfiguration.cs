using FluentDapperFxn.Common.AppSettings;
using FluentDapperFxn.Common.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace FluentDapperFxn.Common
{
    [ExcludeFromCodeCoverage]
    public static class CommonServiceConfiguration
    {

        public static void ConfigureCommon(this IServiceCollection services)
        {
            services.AddSingleton<IAppSettingsService, AppSettingsService>();
        }
    }
}
