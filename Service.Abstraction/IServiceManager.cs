using Services.Services.Contract;

namespace Services.Abstractions
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IRoleService RoleService { get; }
        IPermissionService PermissionService { get; }
    }
}
