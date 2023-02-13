using Clients.Common.DTO_s;
using Clients.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Clients.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HmoController : Controller
    {
        private readonly IHmoService _hmoService;
        public HmoController(IHmoService roleService)
        {
            _hmoService = roleService;

        }
        [HttpGet]
        public async Task<List<HmoDTO>> Get()
        {
            return await _hmoService.GetListAsync();
        }
        [HttpGet("{id}")]
        public async Task<HmoDTO> Get(int id)
        {
            return await _hmoService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<HmoDTO> Add( string name)
        {
            return await _hmoService.AddAsync( name);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _hmoService.DeleteAsync(id);
        }
        [HttpPut("{id},{name}")]
        public async Task<HmoDTO> Put(int id, string name)
        {
            HmoDTO r = new HmoDTO(id, name);
            return await _hmoService.UpdateAsync(r);
        }
    }
}
