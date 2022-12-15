using AutoMapper;
using AvishagProject.common.DTOs;
using AvishagProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvishagProject.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<RoleDTO, Role>().ReverseMap();
            CreateMap<PermissionDTO, Permission>().ReverseMap();
            CreateMap<ClaimDTO, Claim>().ReverseMap();
        }
    }
}
