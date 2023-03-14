using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Services.Contract
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll(CancellationToken cancellationToken = default);
        Task<IEnumerable<User>> GetByRoleId(Guid roleId, CancellationToken cancellationToken = default);
        Task<User> GetById(Guid userId, CancellationToken cancellationToken = default);
        void Insert(User user);
        void Remove(User user);
    }
}
