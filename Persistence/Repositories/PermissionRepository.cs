using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Services.Services.Contract;

namespace Persistence.Repositories
{
    internal sealed class PermissionRepository : IPermissionRepository
    {
        private readonly RepositoryDbContext _dbContext;
        public PermissionRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;
        public async Task<IEnumerable<Permission>> GetAll(CancellationToken cancellationToken = default) =>
            await _dbContext.Permissions.ToListAsync(cancellationToken);
        public async Task<Permission> GetById(Guid permissionId, CancellationToken cancellationToken = default) =>
            await _dbContext.Permissions.Include(x => x.roles).FirstOrDefaultAsync(x => x.permissionIdentifier == permissionId, cancellationToken);
        public void Insert(Permission permission) => _dbContext.Permissions.Add(permission);
        public void Remove(Permission permisson) => _dbContext.Permissions.Remove(permisson);
    }
}
