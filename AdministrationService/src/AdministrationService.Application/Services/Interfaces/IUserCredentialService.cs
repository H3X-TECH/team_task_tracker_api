using AdministrationService.Application.Model.UserCredential;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Application.Services.Interfaces
{
    public interface IUserCredentialService
    {
        Task<bool> Create(CreateUserCredential createModel);
    }
}
