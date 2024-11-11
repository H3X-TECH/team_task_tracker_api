using AdministrationService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3.Domain.Shared.Interfaces;

namespace AdministrationService.Domain.Interfaces
{
    public interface IUserCredentialRepository : IBaseRepository<UserCredential>
    {
    }
}
