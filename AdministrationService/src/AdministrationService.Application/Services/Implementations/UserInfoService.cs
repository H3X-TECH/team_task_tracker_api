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
using T3.Shared;

namespace AdministrationService.Application.Services.Implementations
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoRepository _userInfoRepository;
        
        public UserInfoService(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }

        #region Create UserInfo
        public async Task<ApiResponse<CreateUserInfo>> Create(CreateUserInfo createModel)
        {
            UserInfo userInfo = new UserInfo
            {
                UserId = Guid.NewGuid().ToString(),
                UserName = createModel.UserName,
                Email = createModel.Email,
                CreatedDate = DateTime.Now
            };

            await  _userInfoRepository.AddAsync(userInfo);
            return ApiResponse<CreateUserInfo>.Created(createModel);
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
