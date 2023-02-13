
using Clients.Common.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Services.Interfaces
{
    public interface IHmoService
    {
        Task<List<HmoDTO>> GetListAsync();
        Task<HmoDTO> GetByIdAsync(int id);
        Task<HmoDTO> AddAsync( string name);
        Task<HmoDTO> UpdateAsync(HmoDTO hmo);
        Task DeleteAsync(int id);
    }
}
