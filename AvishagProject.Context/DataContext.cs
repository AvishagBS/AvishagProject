using AvishagProject.Repositories;
using AvishagProject.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace AvishagProject.Context
{
    public class DataContext: DbContext, IContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Claim> Claims { get; set; }

    }
}