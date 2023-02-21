using Clients.Common.DTO_s;
using Clients.Services.Interfaces;
using Clients.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ClientDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClientDTO>> Add([FromBody] ClientModel client)
        {
            List<ChildDTO> children = new List<ChildDTO>();
            client.Children.ForEach(c => children.Add(new ChildDTO(c.IdNumber, c.FirstName, c.BirthDate)));
            if (await _clientService.IsExistsAsync(client.IdNumber) == true)
                return BadRequest();
            ClientDTO c = new ClientDTO(client.IdNumber, client.FirstName, client.LastName, client.BirthDate, client.ToAdvertise,(EGenderDTO) client.Gender, client.MyImpression, client.HmoId, children);
            return await _clientService.AddAsync(c);
        }
        [HttpPut("{id}/children")]
        public async Task<List<ChildDTO>> Update(string id, ChildDTO[] children)
        {
            return await _clientService.UpdateAsync(id, children);
        }
        [HttpPut("{id}")]
        public async Task<ClientDTO> Update(ClientModel client)
        {
            List<ChildDTO> children = new List<ChildDTO>();
            client.Children.ForEach(c => children.Add(new ChildDTO(c.IdNumber, c.FirstName, c.BirthDate)));
            return await _clientService.UpdateAsync(new ClientDTO(client.IdNumber, client.FirstName, client.LastName, client.BirthDate, client.ToAdvertise, (EGenderDTO)client.Gender, client.MyImpression, client.HmoId, children));
        }
        [HttpDelete("{id}")]
        public async Task delete(int id)
        {
            await _clientService.DeleteAsync(id);
        }
    }
}
