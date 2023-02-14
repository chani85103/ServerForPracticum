using Clients.Common.DTO_s;
using Clients.Services.Interfaces;
using Clients.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clients.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        [HttpGet]
        public async Task<List<ClientDTO>> Get()
        {
            return await _clientService.GetListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ClientDTO> Get(int id)
        {
            return await _clientService.GetByIdAsync(id);
        }
        [HttpGet("idNumber/{id}")]
        public async Task<ClientDTO> Get(string id)
        {
            return await _clientService.GetByIdNumberAsync(id);
        }

        [HttpPost]
        public async Task<ClientDTO> Add([FromBody] ClientModel client)
        {
            return await _clientService.AddAsync(new ClientDTO(client.IdNumber, client.FirstName, client.LastName, client.BirthDate, client.ToAdvertise, (EGenderDTO)client.Gender, client.MyImpression, client.HmoId, client.Children));
        }
        [HttpPut("{id}/children")]
        public async Task<List<ChildDTO>> Update(string id, ChildDTO[] children)
        {
            return await _clientService.UpdateAsync(id, children);
        }
        [HttpPut("{id}")]
        public async Task<ClientDTO> Update(ClientModel client)
        {
            return await _clientService.UpdateAsync(new ClientDTO(client.IdNumber,client.FirstName,client.LastName,client.BirthDate,client.ToAdvertise,(EGenderDTO)client.Gender,client.MyImpression,client.HmoId,client.Children));
        }
        [HttpDelete("{id}")]
        public async Task delete(int id)
        {
            await _clientService.DeleteAsync(id);
        }
    }
}
