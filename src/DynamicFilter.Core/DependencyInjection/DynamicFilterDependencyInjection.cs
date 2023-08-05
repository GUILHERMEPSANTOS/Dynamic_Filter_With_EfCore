using DynamicFilter.Core.Factories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DynamicFilter.Core.DependencyInjection
{
    public static class DynamicFilterDependencyInjection
    {
        public static IServiceCollection AddDynamicFilter(this IServiceCollection services)
        {
            services.AddScoped<IDynamicFilter, DynamicFilter>();
            services.AddScoped<IDynamicFilterFactory, DynamicFilterFactory>();

            return services;
        }
    }
}
