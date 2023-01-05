using AvishagProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetAll();
        Task<Role> GetById(int id);
        Task<Role> AddAsync(int id, string name, string description);
        Task<Role> UpdateAsync(Role role);
        Task DeleteAsync(int id);
    }
}
