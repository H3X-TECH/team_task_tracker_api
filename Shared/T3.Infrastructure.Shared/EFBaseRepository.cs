using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using T3.Domain.Shared.Common;
using T3.Domain.Shared.Interfaces;

namespace T3.Infrastructure.Shared
{
    public class EFBaseRepository<TDbContext,TEntity> : IBaseRepository<TEntity> where TDbContext : DbContext where TEntity : BaseEntity
    {
        protected readonly TDbContext _dbContext;
        public EFBaseRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region ADD
        public void Add(TEntity entity) => _dbContext.Add(entity);

        public async Task AddAsync(TEntity entity) => await _dbContext.AddAsync(entity);

        public void AddRange(IEnumerable<TEntity> entities) => _dbContext.AddRange(entities);

        public async Task AddRangeAsync(IEnumerable<TEntity> entities) => await _dbContext.AddRangeAsync(entities);
        #endregion

        #region UPDATE

        #endregion
    }
}
