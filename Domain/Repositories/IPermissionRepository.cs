using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Services.Contract
{
    public interface IPermissionRepository
    {
        Task<IEnumerable<Permission>> GetAll(CancellationToken cancellationToken = default);
        Task<Permission> GetById(Guid permissionId, CancellationToken cancellationToken = default);
        void Insert(Permission permission);
        void Remove(Permission permission);
    }
}
