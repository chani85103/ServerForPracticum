
using Clients.Common.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Services.Interfaces
{
    public interface IClientService
    {
        Task<ClientDTO> GetByIdAsync(string id);
        Task<List<ChildDTO>> UpdateAsync(string id, ChildDTO[] children);
        Task DeleteAsync(string id);
        Task<List<ClientDTO>> GetListAsync();
        Task<ClientDTO> AddAsync(ClientDTO client);
        Task<bool> IsExistsAsync(string id);
    }
}
