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
        List<Claim> GetAll();
        Claim GetById(int id);
        Claim Add(int id, int roleId, int permissionId, EPolicy policy);
        Claim Update(Claim claim);
        void Delete(int id);


    }
}
