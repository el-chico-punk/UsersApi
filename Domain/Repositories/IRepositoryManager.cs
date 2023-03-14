using Services.Services.Contract;

namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IUserRepository UserRepository { get; }
        IPermissionRepository PermissionRepository { get; }
        IRoleRepository RoleRepository { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
