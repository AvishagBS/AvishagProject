﻿using AvishagProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Repositories.Interfaces
{
    public interface IPermissionRepository
    {
        Task<List<Permission>> GetAll();
        Task<Permission> GetById(int id);
        Task<Permission> AddAsync(int id, string name, string description);
        Task<Permission> UpdateAsync(Permission permission);
        Task DeleteAsync(int id);
    }
}
