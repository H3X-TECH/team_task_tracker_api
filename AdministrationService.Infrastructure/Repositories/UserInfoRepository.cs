using AdministrationService.Domain.Entities;
using AdministrationService.Domain.Interfaces;
using AdministrationService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3.Infrastructure.Shared;

namespace AdministrationService.Infrastructure.Repositories
{
    public class UserInfoRepository : EFBaseRepository<AdministrationDbContext,UserInfo>,IUserInfoRepository
    {
        public UserInfoRepository(AdministrationDbContext dbContext):base(dbContext)
        {
            
        }
    }
}
