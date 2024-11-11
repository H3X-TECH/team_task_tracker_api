using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3.Domain.Shared.Interfaces;

namespace T3.Infrastructure.Shared.UnitOfWork
{
    public class UnitOfWork<TDbContext> : IUnitOfWork  where TDbContext : DbContext
    {
        private readonly TDbContext _dbContext;

        public UnitOfWork(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveChanges() => _dbContext.SaveChanges();
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default) => await _dbContext.SaveChangesAsync(cancellationToken);

    }
}
