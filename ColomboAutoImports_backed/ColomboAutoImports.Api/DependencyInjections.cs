using ColomboAutoImports.Api.MappingProfiles;
using ColomboAutoImports.Core.Services;

namespace ColomboAutoImports.Api
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddMappingProfiles(this IServiceCollection services)
        {
            // Register all AutoMapper profiles — starting from your API assembly
            services.AddAutoMapper(typeof(CarModelMappings).Assembly);
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Register all AutoMapper profiles — starting from your API assembly
            services.AddAutoMapper(typeof(CarModelService).Assembly);
            return services;
        }
    }
}
