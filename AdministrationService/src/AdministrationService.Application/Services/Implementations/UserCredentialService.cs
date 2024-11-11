using AdministrationService.Application.Model.UserCredential;
using AdministrationService.Application.Model.UserInfo;
using AdministrationService.Application.Services.Interfaces;
using AdministrationService.Application.Util.Interfaces;
using AdministrationService.Domain.Entities;
using AdministrationService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3.Domain.Shared.Interfaces;

namespace AdministrationService.Application.Services.Implementations
{
    public class UserCredentialService : IUserCredentialService
    {
        private readonly IUserCredentialRepository _userCredentialRepository;
        private readonly IPasswordService _passwordService;
        private readonly IUnitOfWork _unitOfWork;
        public UserCredentialService(IUserCredentialRepository userCredentialRepository,
                                     IPasswordService passwordService,
                                     IUnitOfWork unitOfWork)
        {
            _userCredentialRepository = userCredentialRepository;
            _passwordService = passwordService;
            _unitOfWork = unitOfWork;
        }

        #region Create
        public async Task<bool> Create(CreateUserCredential createModel)
        {
            UserCredential userCredential = new UserCredential
            {
                UserId = createModel.UserId,
                PasswordHash= _passwordService.HashPassword(createModel.Password)
            };

            await _userCredentialRepository.AddAsync(userCredential);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Update
        #endregion

        #region Delete
        #endregion
    }
}
