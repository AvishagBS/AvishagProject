using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AvishagProject.Mock;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Repositories.Repositories;
using AvishagProject.Repositories.Entities;

namespace AvishagProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;
        public PermissionController(IPermissionRepository _IpermissionRepository)
        {
            _permissionRepository = _IpermissionRepository;   
        }
        [HttpGet]
        public List<Permission> Get()
        {
            return _permissionRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Permission GetById(int Id)
        {
            return _permissionRepository.GetById(Id);
        }
        [HttpPost]
        public void insert(int Id, string Name, string Description)
        {
            _permissionRepository.Add(Id, Name, Description);
        }
        [HttpPost]
        public void Update(Permission Permission)
        {
            _permissionRepository.Update(Permission);
        }
        [HttpDelete]
        public void delete(int Id)
        {
            _permissionRepository.Delete(Id);
        }
    }
}
