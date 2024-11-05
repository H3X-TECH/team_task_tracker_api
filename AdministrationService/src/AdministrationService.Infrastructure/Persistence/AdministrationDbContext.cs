using AdministrationService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Infrastructure.Persistence
{
    public class AdministrationDbContext : DbContext
    {
      
        public AdministrationDbContext(DbContextOptions<AdministrationDbContext> options):base(options) 
        {
            
        }

        public DbSet<UserInfo> Users { get; set; }
        public DbSet<UserCredential> UserCredentials { get; set; }
        public DbSet<UserVerification> UserVerifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserInfo>();
            modelBuilder.Entity<UserCredential>();
            modelBuilder.Entity<UserVerification>();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
