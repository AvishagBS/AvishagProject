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
        public PermissionService(IPermissionRepository permisssionRepository)
        {
            _permisssionRepository = permisssionRepository;
        }
        public List<PermissionDTO> GetAll()
        {
            return _permisssionRepository.GetAll();
        }
        public PermissionDTO GetById(int id)
        {
            return _permisssionRepository.GetById(id);
        }
        public async Task<PermissionDTO> AddAsync(int id, string name, string description)
        {
            return await _permisssionRepository.AddAsync(id, name, description);

        }
        public async Task<PermissionDTO> UpdateAsync(PermissionDTO permission)
        {
            return await _permisssionRepository.UpdateAsync(permission);
        }
        public async Task DeleteAsync(int id)
        {
            await _permisssionRepository.DeleteAsync(id);
        }
    }
}
