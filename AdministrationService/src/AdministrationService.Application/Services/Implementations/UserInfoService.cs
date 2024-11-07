using AdministrationService.Application.Model.UserInfo;
using AdministrationService.Application.Services.Interfaces;
using AdministrationService.Domain.Entities;
using AdministrationService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<string> Create(CreateUserInfo createModel)
        {
            UserInfo userInfo = new UserInfo
            {
                UserId = Guid.NewGuid().ToString(),
                UserName = createModel.UserName,
                Email = createModel.Email,
                CreatedDate = DateTime.Now
            };

            await  _userInfoRepository.AddAsync(userInfo);
            return "";
        }
        #endregion

        #region Update UserInfo
        #endregion

        #region Delete UserInfo
        #endregion

    }
}
