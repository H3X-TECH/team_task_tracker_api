using AdministrationService.Application.Model.UserInfo;
using AdministrationService.Application.Services.Interfaces;
using AdministrationService.Domain.Entities;
using AdministrationService.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3.Domain.Shared.Interfaces;
using T3.Shared;

namespace AdministrationService.Application.Services.Implementations
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoRepository _userInfoRepository;
        private readonly IUnitOfWork _unitOfWork;
        
        public UserInfoService(IUserInfoRepository userInfoRepository,
                               IUnitOfWork unitOfWork)
        {
            _userInfoRepository = userInfoRepository;
            _unitOfWork = unitOfWork;
        }

        #region Create UserInfo
        public async Task<UserInfo> Create(CreateUserInfo createModel)
        {
            UserInfo userInfo = new UserInfo
            {
                UserId = Guid.NewGuid().ToString(),
                UserName = createModel.UserName,
                Email = createModel.Email,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                IsEmailVerified = ""
            };

            await  _userInfoRepository.AddAsync(userInfo);
            await _unitOfWork.SaveChangesAsync();
            return userInfo;
        }
        #endregion

        #region Update UserInfo
        public async Task<string> Update(UpdateUserInfo updateModel)
        {
            return "";
        }
        #endregion

        #region Delete UserInfo
        public async Task<string> Delete(string Id)
        {
            return "";
        }
        #endregion

    }
}
