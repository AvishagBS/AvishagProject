using AvishagProject.Repositories.Entities;
using AvishagProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Mock
{
    public class MockContext : IContext
    {
        public List<Claim> Claims { get; set; }
        public List<Role> Roles { get; set; }
        public List<Permission> Permissions { get; set; }

        public MockContext()
        {
            Claims = new List<Claim>();
            Roles = new List<Role>();
            Permissions = new List<Permission>();

            Claims.Add(new Claim { Id = 111, RoleId = 111, PermissionId = 1111, Policy = EPolicy.Allow });
            Claims.Add(new Claim { Id = 222, RoleId = 222, PermissionId = 2222, Policy = EPolicy.Deny });
            Roles.Add(new Role { Id = 111, Name = "admin", Description = "the head" });
            Roles.Add(new Role { Id = 222, Name = "student", Description = "student in high school" });
            Permissions.Add(new Permission { Id = 1111, Name = "ViewAllGrades", Description = "the high and the low grades" });
            Permissions.Add(new Permission { Id = 2222, Name = "ViewAllActivities", Description = "the trips and programs" });



        }
    }
}
