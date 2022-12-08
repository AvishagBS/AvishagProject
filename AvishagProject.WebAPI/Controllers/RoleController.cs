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
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpGet]
        public List<RoleDTO> Get()
        {
            return _roleService.GetAll();
        }
        [HttpGet("{id}")]
        public RoleDTO GetById(int id)
        {
            return _roleService.GetById(id);
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
