using Clients.Repository.Entities;
using Clients.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Clients.Context
{
    public class ClientsDBContext : DbContext,IContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<HMO> HMOs { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CLientsDBContext;Trusted_Connection=True");
        }
       
    }
}