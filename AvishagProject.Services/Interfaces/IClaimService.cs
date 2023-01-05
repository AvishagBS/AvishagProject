using AvishagProject.common.DTOs;
using AvishagProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Services.Interfaces
{
    public interface IClaimService
    {
        Task<List<ClaimDTO>> GetAll();
        Task<ClaimDTO> GetById(int id);
        Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, AvishagProject.Repositories.Entities.EPolicy policy);
        Task<ClaimDTO> UpdateAsync(ClaimDTO claim);
        Task DeleteAsync(int id);
    }
}
