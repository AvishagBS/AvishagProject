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
    public class RoleController : ControllerBase
    {

        private readonly IRoleRepository _roleRepository;
        public RoleController(IRoleRepository _IroleRepository)
        {
            _roleRepository = _IroleRepository;
        }
        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Role GetById(int Id)
        {
            return _roleRepository.GetById(Id);
        }
        [HttpPost]
        public void insert(int Id, string Name, string Description)
        {
            _roleRepository.Add(Id, Name, Description);
        }
        [HttpPost]
        public void Update(Role Role)
        {
            _roleRepository.Update(Role);
        }
        [HttpDelete]
        public void delete(int Id)
        {
            _roleRepository.Delete(Id);
        }
    }
}
