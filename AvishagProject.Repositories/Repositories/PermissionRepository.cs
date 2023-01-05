using AvishagProject.Repositories.Entities;
using AvishagProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        public async Task<List<Permission>> GetAll()
        {
            return await _context.Permissions.ToListAsync();
        }
        public async Task<Permission> GetById(int id)
        {
            return await _context.Permissions.FindAsync(id);
        }
        public async Task< Permission> AddAsync(int id, string name, string description)
        {
            Permission p = new Permission { Id = id, Name = name, Description = description };
            _context.Permissions.Add(p);
            await _context.SaveChangesAsync();
            return p;

        }
        public async Task< Permission> UpdateAsync(Permission permission)
        {
            var p = await GetById(permission.Id);
            permission.Name = p.Name;
            permission.Description = p.Description;
            await _context.SaveChangesAsync();
            return permission;
        }
        public async Task DeleteAsync(int id)
        {
            var p = _context.Permissions.First(x => x.Id == id);
            _context.Permissions.Remove(p);
            await _context.SaveChangesAsync();
        }

    }
}
