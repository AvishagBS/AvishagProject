using AvishagProject.Repositories;
using AvishagProject.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AvishagProject.Services
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IClaimService, ClaimService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}