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
    public class ClaimService : IClaimService
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimService(IClaimRepository claimRepository)
        {
            _claimRepository=claimRepository;
        }
        public List<ClaimDTO> GetAll()
        {
            return  _claimRepository.GetAll();
        }
        public Claim GetById(int id)
        {
            return _claimRepository.GetById(id);
        }
        public async Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, EPolicy policy)
        {
          return await _claimRepository.AddAsync(id, roleId, permissionId, policy);

        }
        public async Task<ClaimDTO> UpdateAsync(ClaimDTO claim)
        {
           return await _claimRepository.UpdateAsync(claim);
        }
        public async Task DeleteAsync(int id)
        {
          await _claimRepository.DeleteAsync(id);
        }
    }
}
