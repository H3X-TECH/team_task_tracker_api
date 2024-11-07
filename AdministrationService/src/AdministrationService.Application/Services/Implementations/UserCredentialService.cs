using AdministrationService.Application.Services.Interfaces;
using AdministrationService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Application.Services.Implementations
{
    public class UserCredentialService : IUserCredentialService
    {
        private readonly IUserCredentialService _userCredentialService;
        public UserCredentialService(IUserCredentialService userCredentialService)
        {
            _userCredentialService = userCredentialService;
        }
    }
}
