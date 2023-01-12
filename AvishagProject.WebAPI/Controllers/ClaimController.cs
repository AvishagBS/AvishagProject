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
        private readonly ILogger<RoleController> _logger;

        public ClaimController(IClaimService claimService, ILogger<RoleController> logger)
        {
            _claimService = claimService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<List<ClaimDTO>> Get()
        {
            _logger.LogInformation($"{HttpContext.Items["RequestSequence"]}Get all claims");
            return await _claimService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ClaimDTO>> GetById(int id)
        {

            _logger.LogInformation($"{HttpContext.Items["RequestSequence"]}Get all by id Claim STARTS");
            var claim = await _claimService.GetById(id);
            if (claim is null)
            {
                return NotFound();
            }
            _logger.LogInformation($"{HttpContext.Items["RequestSequence"]}Get all by id Claim END");
            return claim;
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
