
using Clients.Common.DTO_s;
using Clients.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Services.Interfaces
{
    public interface IClientService
    {
       
        Task<ClientDTO> GetByIdAsync(int id);
        Task<ClientDTO> GetByIdNumberAsync(string idNumber);
        Task<List<ChildDTO>> UpdateAsync(string id, ChildDTO[] children);
        Task<List<ClientDTO>> GetListAsync();
        Task<ClientDTO> AddAsync(ClientDTO client);
        Task<bool> IsExistsAsync(string idNumber);
        Task<ClientDTO> UpdateAsync(ClientDTO client);
        Task DeleteAsync(int id);
    }
}
