using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AvishagProject.Repositories
{
    public static class Extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IClaimRepository, ClaimRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            return services;
        }
    }
}
