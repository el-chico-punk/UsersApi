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
    internal sealed class UserRepository : IUserRepository
    {
        private readonly RepositoryDbContext _dbContext;
        public UserRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;
        public async Task<IEnumerable<User>> GetAll(CancellationToken cancellationToken = default) =>
            await _dbContext.Users.Include(x => x.roles).ToListAsync(cancellationToken);
        public async Task<IEnumerable<User>> GetByRoleId(Guid roleId, CancellationToken cancellationToken = default) =>
           await _dbContext.Users.Include(x => x.roles).Where(x => x.roles.Count(x => x.roleIdentifier== roleId) >= 1).ToListAsync(cancellationToken);
        public async Task<User> GetById(Guid userId, CancellationToken cancellationToken = default) =>
            await _dbContext.Users.Include(x => x.roles).FirstOrDefaultAsync(x => x.userIdentifier == userId, cancellationToken);
        public void Insert(User user) => _dbContext.Users.Add(user);
        public void Remove(User user) => _dbContext.Users.Remove(user);
    }
}
