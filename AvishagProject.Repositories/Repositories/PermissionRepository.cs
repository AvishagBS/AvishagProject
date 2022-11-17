using AvishagProject.Repositories.Entities;
using AvishagProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Repositories.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IContext _context ;
        public PermissionRepository(IContext _context)
        {
            _context = _context;
        }
        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }
        public Permission GetById(int id)
        {
            return _context.Permissions.First(x => x.Id == id);
        }
        public Permission Add(int id, string name, string description)
        {
            Permission p = new Permission { Id = id, Name = name, Description = description };
            _context.Permissions.Add(p);
            return p;

        }
        public Permission Update(Permission permission)
        {
            var p = GetById(permission.Id);
            permission.Name = p.Name;
            permission.Description = p.Description;
            return permission;
        }
        public void Delete(int id)
        {
            var p = _context.Permissions.First(x => x.Id == id);
            _context.Permissions.Remove(p);
        }

    }
}
