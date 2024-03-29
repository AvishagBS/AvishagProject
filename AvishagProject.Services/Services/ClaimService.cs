﻿using AutoMapper;
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
        private readonly IMapper _mapper;
        public ClaimService(IClaimRepository claimRepository,IMapper mapper)
        {
            _claimRepository=claimRepository;
            _mapper=mapper;
        }
        public async Task<List<ClaimDTO>> GetAll()
        {
            return  _mapper.Map<List<ClaimDTO>>(_claimRepository.GetAll());
        }
        public async Task<ClaimDTO> GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(await _claimRepository.GetById(id));
        }
        public async Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId,AvishagProject.Repositories.Entities.EPolicy policy)
        {
            return _mapper.Map<ClaimDTO>(await _claimRepository.AddAsync(id, roleId, permissionId, policy));

        }
        public async Task<ClaimDTO> UpdateAsync(ClaimDTO claim)
        {
           return _mapper.Map<ClaimDTO>(await _claimRepository.UpdateAsync(_mapper.Map<Claim>(claim)));
        }
        public async Task DeleteAsync(int id)
        {
          await _claimRepository.DeleteAsync(id);
        }
    }
}
