using AutoMapper;
using AvishagProject.common.DTOs;
using AvishagProject.Repositories.Entities;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permisssionRepository;
        private readonly IMapper _mapper;

        public PermissionService(IPermissionRepository permisssionRepository)
        {
            _permisssionRepository = permisssionRepository;
        }
        public async Task<List<PermissionDTO>> GetAll()
        {
            return _mapper.Map< List < PermissionDTO >>(await _permisssionRepository.GetAll()) ;
        }
        public async Task<PermissionDTO> GetById(int id)
        {
            return _mapper.Map<PermissionDTO>(await _permisssionRepository.GetById(id));
        }
        public async Task<PermissionDTO> AddAsync(int id, string name, string description)
        {
            return _mapper.Map<PermissionDTO>( await _permisssionRepository.AddAsync(id, name, description));

        }
        public async Task<PermissionDTO> UpdateAsync(PermissionDTO permission)
        {
            return _mapper.Map<PermissionDTO>(await _permisssionRepository.UpdateAsync(_mapper.Map<Permission>(permission)));
        }
        public async Task DeleteAsync(int id)
        {
            await _permisssionRepository.DeleteAsync(id);
        }
    }
}
