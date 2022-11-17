using AvishagProject.Mock;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Repositories.Repositories;
using AvishagProject.Repositories.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvishagProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {

        private readonly IClaimRepository _claimRepository;
        public ClaimController(IClaimRepository _IclaimRepository)
        {
            _claimRepository = _IclaimRepository;
        }
        [HttpGet]
        public List<Claim> Get()
        {
            return _claimRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Claim GetById(int Id)
        {
            return _claimRepository.GetById(Id);
        }
        [HttpPost]
        public void insert(int Id, int RoleId, int PermissionId, EPolicy Policy)
        {
            _claimRepository.Add(Id, RoleId, PermissionId, Policy);
        }
        [HttpPost]
        public void Update(Claim Claim)
        {
            _claimRepository.Update(Claim);
        }
        [HttpDelete]
        public void delete(int Id)
        {
            _claimRepository.Delete(Id);
        }
        // chek
    }
}
