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
    public class EFBaseRepository<TDbContext,TEntity> : IBaseRepository where TDbContext : DbContext where TEntity : BaseEntity
    {
        protected readonly TDbContext _dbContext;
        public EFBaseRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
