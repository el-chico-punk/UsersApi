using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Services.Contract
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetAll(CancellationToken cancellationToken = default);
        Task<Role> GetById(Guid roleId, CancellationToken cancellationToken = default);
        void Insert(Role role);
        void Remove(Role role);
    }
}
