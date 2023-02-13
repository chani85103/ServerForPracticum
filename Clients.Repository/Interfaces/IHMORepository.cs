using Clients.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Interfaces
{
    public interface IHmoRepository
    {
        Task<List<HMO>> GetAllAsync();
        Task<HMO> GetByIdAsync(int Id);
        Task<HMO> AddAsync(string name);
        Task<HMO> UpdateAsync(HMO c);
        Task DeleteAsync(int id);
    }
    
}
