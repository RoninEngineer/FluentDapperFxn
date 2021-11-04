using FluentDapperFxn.Domain.Dto;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace FluentDapperFxn.Domain
{
    public static class DomainConfiguration
    {
        public static void ConfigureDomain(this IServiceCollection services)
        {
            services.AddTransient<IValidator<SystemLookup>, SystemLookupValidator>();

        }
    }
}
