using AdministrationService.Application.Services.Implementations;
using AdministrationService.Application.Services.Interfaces;
using AdministrationService.Application.Util.Implementations;
using AdministrationService.Application.Util.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Application
{
    public static class ApplicationServiceCollectionExtension
    {
        public static void RegisterApplicationDependencies(this IServiceCollection services)
        {
            #region User
            services.AddScoped<IUserInfoService, UserInfoService>();
            services.AddScoped<IUserCredentialService, UserCredentialService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserVerificationService, UserVerificationService>();
            #endregion

            #region Token
            services.AddScoped<ITokenService, TokenService>();
            #endregion

            #region Password
            services.AddScoped<IPasswordService,PasswordService>();
            #endregion
        }
    }
}
