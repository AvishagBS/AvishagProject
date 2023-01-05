using AvishagProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AvishagProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        Task<List<Claim>> GetAll();
        Task<Claim> GetById(int id);
        Task<Claim> AddAsync(int id, int roleId, int permissionId, EPolicy policy);
        Task< Claim> UpdateAsync(Claim claim);
        Task DeleteAsync(int id);


    }
}
