using AvishagProject.Repositories.Entities;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Services.Interfaces;
using AvishagProject.common.DTOs;
using AutoMapper;

namespace AvishagProject.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public RoleService(IRoleRepository roleRepository,IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public async Task<List<RoleDTO>> GetAll()
        {
            return _mapper.Map<List<RoleDTO>>(await _roleRepository.GetAll());
        }
        public async Task<RoleDTO> GetById(int id)
        {
            return _mapper.Map<RoleDTO>(await _roleRepository.GetById(id));
        }
        public async Task<RoleDTO> AddAsync(int id, string name, string description)
        {
            return _mapper.Map<RoleDTO>( await _roleRepository.AddAsync(id, name, description));

        }
        public async Task<RoleDTO> UpdateAsync(RoleDTO role)
        {
            return _mapper.Map<RoleDTO>(await _roleRepository.UpdateAsync(_mapper.Map<Role>(role)));
        }
        public async Task DeleteAsync(int id)
        {
            await _roleRepository.DeleteAsync(id);
        }
    }
}