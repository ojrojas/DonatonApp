using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.AppContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        /// <summary>
        /// Security Users Application
        /// </summary>
        /// <value></value>
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        /// <summary>
        /// Data Entitites Application
        /// </summary>
        /// <value></value>
        public DbSet<TypeIdentification> TypeIdentifications { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<DonationMoney> DonationMoneys { get; set; }
        public DbSet<DonationNonPerishable> DonationNonPerishables { get; set; }
        public DbSet<DonationPerishable> DonationPerishables { get; set; }
        public DbSet<StateMaterial> StateMaterials { get; set; }
        public DbSet<TypeDonation> TypeDonation { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}