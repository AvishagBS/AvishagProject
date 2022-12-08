using AvishagProject.Repositories.Entities;
using AvishagProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {

        private readonly IContext _context;
        public RoleRepository(IContext _context)
        {
            _context = _context;
        }
        public List<Role> GetAll()
        {
            return _context.Roles;
        }
        public Role GetById(int id)
        {
            return _context.Roles.First(x => x.Id == id);
        }
        public async Task<Role> AddAsync(int id, string name, string description)
        {
            Role r = new Role { Id = id, Name = name, Description = description };
            _context.Roles.Add(r);
            await _context.SaveChangesAsync();
            return r;

        }
        public async Task<Role> UpdateAsync(Role role)
        {
            var r = GetById(role.Id);
            role.Name = r.Name;
            role.Description = r.Description;
            await _context.SaveChangesAsync();
            return role;
        }
        public async Task DeleteAsync(int id)
        {
            var r = _context.Roles.First(x => x.Id == id);
            _context.Roles.Remove(r);
            await _context.SaveChangesAsync();
        }


    }
}
