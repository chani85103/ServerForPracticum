using Clients.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Interfaces
{
    public interface IContext
    {
        DbSet<Client> Clients { get;set; }  
        DbSet<HMO> HMOs { get;set; }
        DbSet<Child> Children { get;set; }  
        Task<int>SaveChangesAsync(CancellationToken cancellationToken=default);
    }
}
