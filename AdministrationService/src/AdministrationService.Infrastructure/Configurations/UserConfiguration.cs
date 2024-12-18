﻿using AdministrationService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Infrastructure.Configurations
{
    public class UserInfoConfiguration : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.HasKey(u => u.UserId);
            builder.HasOne(u => u.UserCredentials)
                   .WithOne(uc => uc.UserInfo)
                   .HasForeignKey<UserCredential>(uc => uc.UserId);

        }
    }

    public class UserCredentialConfiguration : IEntityTypeConfiguration<UserCredential>
    {
        public void Configure(EntityTypeBuilder<UserCredential> builder)
        {
            builder.HasKey(uc => uc.UserId);


            //builder.Property(uc => uc.UserId)  // Specify the foreign key if it's not nullable
            //       .IsRequired();

            //builder.HasOne(uc => uc.UserInfo)
            //       .WithOne(u => u.UserCredentials)
            //       .HasForeignKey<UserCredential>(uc => uc.UserId);
        }
    }

    public class UserVerificationConfiguration : IEntityTypeConfiguration<UserVerification>
    {
        public void Configure(EntityTypeBuilder<UserVerification> builder)
        {
            builder.HasKey(uv => uv.UserVerificationId);
        }
    }
}
