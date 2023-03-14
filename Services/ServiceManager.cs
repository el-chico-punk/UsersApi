using System;
using Domain.Repositories;
using Services.Abstractions;
using Services.Services.Contract;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _lazyUserService;
        private readonly Lazy<IRoleService> _lazyRoleService;
        private readonly Lazy<IPermissionService> _lazyPermissionService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyUserService = new Lazy<IUserService>(() => new UserService(repositoryManager));
            _lazyRoleService = new Lazy<IRoleService>(() => new RoleService(repositoryManager));
            _lazyPermissionService = new Lazy<IPermissionService>(() => new PermissionService(repositoryManager));
        }

       public IUserService UserService => _lazyUserService.Value;

       public IRoleService RoleService => _lazyRoleService.Value;

       public IPermissionService PermissionService => _lazyPermissionService.Value;
    }
}