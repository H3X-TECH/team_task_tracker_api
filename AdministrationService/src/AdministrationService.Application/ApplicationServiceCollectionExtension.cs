using AdministrationService.Application.Services.Implementations;
using AdministrationService.Application.Services.Interfaces;
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
            services.AddScoped<IUserService, UserService>();
            #endregion

            #region Token
            services.AddScoped<ITokenService, TokenService>();
            #endregion
        }
    }
}
