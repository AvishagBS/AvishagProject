using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AvishagProject.Mock;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Repositories.Repositories;
using AvishagProject.Repositories.Entities;
using AvishagProject.common.DTOs;
using AvishagProject.Services.Interfaces;

namespace AvishagProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;
        private readonly ILogger<RoleController> _logger;

        public PermissionController(IPermissionService permissionService, ILogger<RoleController> logger)
        {
            _permissionService = permissionService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<List<PermissionDTO>> Get()
        {
            _logger.LogInformation($"{HttpContext.Items["RequestSequence"]}Get all Permission");
            return await _permissionService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PermissionDTO>> GetById(int id)
        {
            _logger.LogInformation($"{HttpContext.Items["RequestSequence"]}Get all by id Permission STARTS");
            var permission = await _permissionService.GetById(id);
            if (permission is null)
            {
                return NotFound();
            }
            _logger.LogInformation($"{HttpContext.Items["RequestSequence"]}Get all by id Permission END");
            return permission;
        }
        [HttpPost]
        public async Task InsertAsync(int id, string name, string description)
        {
            await _permissionService.AddAsync(id, name, description);
        }
        [HttpPost]
        public async Task UpdateAsync(PermissionDTO permission)
        {
            await _permissionService.UpdateAsync(permission);
        }
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _permissionService.DeleteAsync(id);
        }
    }
}
