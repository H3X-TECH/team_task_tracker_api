using AdministrationService.Domain.Interfaces;
using AdministrationService.Infrastructure.Persistence;
using AdministrationService.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Infrastructure
{
    public static class InfraServiceCollectionExtension
    {
        public static void RegisterInfraDependencies(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AdministrationDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnectionString")));
            #region Repository
            services.AddScoped<IUserCredentialRepository,UserCredentialRepository>();
            services.AddScoped<IUserInfoRepository,UserInfoRepository>();
            services.AddScoped<IUserVerificationRepository,UserVerificationRepository>();
            #endregion
        }
    }
}
