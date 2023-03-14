using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Services.Services.Contract;

namespace Persistence.Repositories
{
    internal sealed class RoleRepository : IRoleRepository
    { 

        private readonly RepositoryDbContext _dbContext;
        public RoleRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;
        public async Task<IEnumerable<Role>> GetAll(CancellationToken cancellationToken = default) =>
            await _dbContext.Roles.Include(x => x.permissions).ToListAsync(cancellationToken);
        public async Task<Role> GetById(Guid roleId, CancellationToken cancellationToken = default) =>
            await _dbContext.Roles.Include(x => x.permissions).FirstOrDefaultAsync(x => x.roleIdentifier == roleId, cancellationToken);
        public void Insert(Role role) => _dbContext.Roles.Add(role);
        public void Remove(Role role) => _dbContext.Roles.Remove(role);
    
    }
}