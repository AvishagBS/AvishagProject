using AvishagProject.Mock;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Repositories.Repositories;
using AvishagProject.Repositories.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AvishagProject.common.DTOs;
using AvishagProject.Services.Interfaces;

namespace AvishagProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {

        private readonly IClaimService _claimService;
        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }
        [HttpGet]
        public async Task<List<ClaimDTO>> Get()
        {
            return await _claimService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ClaimDTO> GetById(int id)
        {
            return await _claimService.GetById(id);
        }
        [HttpPost]
        public async Task InsertAsync(int id, int roleId, int permissionId, AvishagProject.Repositories.Entities.EPolicy policy)
        {
            await _claimService.AddAsync( id,  roleId,  permissionId,  policy);
        }

        [HttpPost]
        public async Task UpdateAsync(ClaimDTO claim)
        {
            await _claimService.UpdateAsync(claim);
        }

        [HttpDelete]
        public async  Task DeleteAsync(int id)
        {
            await _claimService.DeleteAsync(id);
        }
    }
}
