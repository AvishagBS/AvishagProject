using AvishagProject.Repositories.Entities;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Services.Interfaces;
using AvishagProject.common.DTOs;

namespace AvishagProject.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public List<RoleDTO> GetAll()
        {
            return _roleRepository.GetAll();
        }
        public RoleDTO GetById(int id)
        {
            return _roleRepository.GetById(id);
        }
        public async Task<RoleDTO> AddAsync(int id, string name, string description)
        {
            return await _roleRepository.AddAsync(id, name, description);

        }
        public async Task<RoleDTO> UpdateAsync(RoleDTO role)
        {
            return await _roleRepository.UpdateAsync(role);
        }
        public async Task DeleteAsync(int id)
        {
            await _roleRepository.DeleteAsync(id);
        }
    }
}