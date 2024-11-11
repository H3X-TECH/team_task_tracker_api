using AdministrationService.Application.Model.UserInfo;
using AdministrationService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3.Shared;

namespace AdministrationService.Application.Services.Interfaces
{
    public interface IUserInfoService
    {
        Task<UserInfo> Create(CreateUserInfo createModel);
    }
}
