using AvishagProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Repositories.Interfaces
{
    public interface IContext
    {
        public List<Claim> Claims { get; set; }
        public List<Role> Roles { get; set;}
        public List<Permission> Permissions { get; set; }
    }
}
