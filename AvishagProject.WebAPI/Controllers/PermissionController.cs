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
        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [HttpGet]
        public async Task<List<PermissionDTO>> Get()
        {
            return await _permissionService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<PermissionDTO> GetById(int id)
        {
            return await _permissionService.GetById(id);
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
