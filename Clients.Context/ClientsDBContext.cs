using Clients.Repository.Entities;
using Clients.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Clients.Context
{
    public class ClientsDBContext : DbContext,IContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<HMO> HMOs { get; set; } 
        public DbSet<Child> Children { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CLientsDBContext;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>()
                .HasIndex(u => u.IdNumber)
                .IsUnique();
            builder.Entity<Child>()
                .HasIndex(u => u.IdNumber)
                .IsUnique();
        }
    }
}