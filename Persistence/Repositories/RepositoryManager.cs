using System;
using Domain.Repositories;
using Services.Services.Contract;

namespace Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IUserRepository> _lazyUserRepository;
        private readonly Lazy<IRoleRepository> _lazyRoleRepository;
        private readonly Lazy<IPermissionRepository> _lazyPermissionRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(dbContext));
            _lazyRoleRepository = new Lazy<IRoleRepository>(() => new RoleRepository(dbContext));
            _lazyPermissionRepository = new Lazy<IPermissionRepository>(() => new  PermissionRepository (dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }

        public IUserRepository UserRepository => _lazyUserRepository.Value;

        public IRoleRepository RoleRepository => _lazyRoleRepository.Value;

        public IPermissionRepository PermissionRepository => _lazyPermissionRepository.Value;

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}
