using Contracts.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Services.Contract
{
    public interface IPermissionService
    {
        Task<IEnumerable<Permission>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<Permission> GetByIdAsync(Guid permissionId, CancellationToken cancellationToken = default);

        Task<Permission> CreateAsync(PermissionForCreationDto permissionForCreation, CancellationToken cancellationToken = default);

        Task UpdateAsync(Guid permissionId, PermissionForUpdateDto permissionForUpdate, CancellationToken cancellationToken = default);

        Task DeleteAsync(Guid permissionId, CancellationToken cancellationToken = default);
    }
}
