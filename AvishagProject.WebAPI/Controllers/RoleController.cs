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
    public class RoleController : ControllerBase
    {

        private readonly IRoleService _roleService;
        private readonly ILogger<RoleController> _logger;
        public RoleController(IRoleService roleService, ILogger<RoleController> logger)
        {
            _roleService = roleService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<List<RoleDTO>> Get()
        {
            _logger.LogInformation($"{HttpContext.Items["RequestSequence"]}Get all Roles");
            return await _roleService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RoleDTO>> GetById(int id)
        {
            _logger.LogInformation($"{HttpContext.Items["RequestSequence"]}Get all by id Roles STARTS");
            var role= await _roleService.GetById(id);
            if(role is null)
            {
                return NotFound();
            }
            _logger.LogInformation($"{HttpContext.Items["RequestSequence"]}Get all by id Roles END");
            return role;
        }
        [HttpPost]
        public async Task InsertAsync(int id, string name, string description)
        {
            await _roleService.AddAsync(id, name, description);
        }
        [HttpPost]
        public async Task UpdateAsync(RoleDTO role)
        {
            await _roleService.UpdateAsync(role);
        }
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _roleService.DeleteAsync(id);
        }
    }
}
