using DemoStoreEFCoreSidekick.WebApi;
using Microsoft.Extensions.DependencyInjection;

namespace DemoStoreEFCoreSidekick.WebApi
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;
        }
    }
}
