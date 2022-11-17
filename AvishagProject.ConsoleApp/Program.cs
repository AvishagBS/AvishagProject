using AvishagProject.Mock;
using AvishagProject.Repositories.Entities;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Repositories.Repositories;

IContext mock = new MockContext();
IRoleRepository roleRepository = new RoleRepository(mock);
IPermissionRepository PermissionRepository = new PermissionRepository(mock); 
IClaimRepository claimRepository = new ClaimRepository(mock);
roleRepository.Add(125,  "adminary",  "perfect acsses" );