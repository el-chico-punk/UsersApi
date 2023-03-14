using Contracts.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Services.Contract
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<IEnumerable<User>> GetByRoleIdAsync(Guid rolId, CancellationToken cancellationToken = default);

        Task<User> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);

        Task<User> CreateAsync(UserForCreationDto userForCreation, CancellationToken cancellationToken = default);

        Task UpdateAsync(Guid userId, UserForUpdateDto userForUpdate, CancellationToken cancellationToken = default);

        Task DeleteAsync(Guid userId, CancellationToken cancellationToken = default);
    }
}
