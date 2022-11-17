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
        List<Role> GetAll();
        Role GetById(int id);
        Role Add(int id, string name, string description);
        Role Update(Role role);
        void Delete(int id);
    }
}
