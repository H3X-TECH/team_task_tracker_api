using AdministrationService.Domain.Entities;
using AdministrationService.Domain.Interfaces;
using AdministrationService.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3.Infrastructure.Shared;

namespace AdministrationService.Infrastructure.Repositories
{
    public class UserVerificationRepository : EFBaseRepository<AdministrationDbContext, UserVerification>, IUserVerificationRepository
    {
        public UserVerificationRepository(AdministrationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
