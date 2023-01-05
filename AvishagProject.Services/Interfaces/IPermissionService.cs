using AvishagProject.common.DTOs;
using AvishagProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Services.Interfaces
{
    public interface IPermissionService
    {
        Task<List<PermissionDTO>> GetAll();
        Task<PermissionDTO> GetById(int id);
        Task<PermissionDTO> AddAsync(int id, string name, string description);
        Task<PermissionDTO> UpdateAsync(PermissionDTO permission);
        Task DeleteAsync(int id);
    }
}
