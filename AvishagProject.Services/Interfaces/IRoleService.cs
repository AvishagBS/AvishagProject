﻿using AvishagProject.common.DTOs;
using AvishagProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Services.Interfaces
{
    public interface IRoleService
    {
        List<RoleDTO> GetAll();
        RoleDTO GetById(int id);
        Task<RoleDTO> AddAsync(int id, string name, string description);
        Task<RoleDTO> UpdateAsync(RoleDTO role);
        Task DeleteAsync(int id);
    }
}
