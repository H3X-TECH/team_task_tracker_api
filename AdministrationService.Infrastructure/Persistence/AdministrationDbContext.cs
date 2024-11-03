using AdministrationService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Infrastructure.Persistence
{
    public class AdministrationDbContext : DbContext
    {
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<UserCredential> UserCredentials { get; set; }
        public DbSet<UserVerification> UserVerifications { get; set; }
        public AdministrationDbContext(DbContextOptions<AdministrationDbContext> options):base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserInfo>();
            modelBuilder.Entity<UserCredential>();
            modelBuilder.Entity<UserVerification>();
        }
    }
}
