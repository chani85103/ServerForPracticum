using Clients.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Interfaces
{
    public interface IClientRepository
    {
        Task<List<Client>> GetAllAsync();
        Task<Client> GetByIdAsync(string Id);
        Task<Client> AddAsync(Client client);
        Task<List<Child>> UpdateAsync(string id, Child[] children);
        Task DeleteAsync(string id);
        Task<bool> IsExistsAsync(string id);
    }
}
