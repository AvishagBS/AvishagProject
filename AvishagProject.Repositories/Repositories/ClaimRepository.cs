using AvishagProject.Repositories.Entities;
using AvishagProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace AvishagProject.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContext _context;
        public ClaimRepository(IContext _context)
        {
            _context = _context;
        }
        public  List<Claim> GetAll()
        {
            return _context.Claims;
        }
        public Claim GetById(int id)
        {
            return _context.Claims.First(x => x.Id == id);
        }
        public async Task< Claim> AddAsync(int id, int roleId, int permissionId, EPolicy policy)
        {
            Claim c = new Claim { Id = id, RoleId = roleId, PermissionId = permissionId, Policy = policy };
            _context.Claims.Add(c);
            await _context.SaveChangesAsync();
            return c;

        }
        public async Task<Claim> UpdateAsync(Claim claim)
        {
            var c = GetById(claim.Id);
            claim.RoleId = c.RoleId;
            claim.PermissionId = c.PermissionId;
            await _context.SaveChangesAsync();
            return claim;
        }
        public async Task DeleteAsync(int id)
        {
            var c = _context.Claims.First(x => x.Id == id);
            _context.Claims.Remove(c);
            await _context.SaveChangesAsync();
        }


    }
}
