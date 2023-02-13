using AutoMapper;
using Clients.Common.DTO_s;
using Clients.Repository.Entities;
using Clients.Repository.Interfaces;
using Clients.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Services.Services
{
    public class HmoService : IHmoService
    {
        private readonly IHmoRepository _hmoRepository;
        private readonly IMapper _mapper;

        public HmoService(IHmoRepository HmoRepository, IMapper mapper)
        {
            _hmoRepository = HmoRepository;
            _mapper = mapper;
        }



        public async Task<HmoDTO> AddAsync(string name)
        {
            return _mapper.Map<HmoDTO>(await _hmoRepository.AddAsync(name));
        }

        public async Task DeleteAsync(int id)
        {
            await _hmoRepository.DeleteAsync(id);
        }

        public Task<List<HmoDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<HmoDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<HmoDTO>(await _hmoRepository.GetByIdAsync(id));
        }


        public async Task<List<HmoDTO>> GetListAsync()
        {
            return _mapper.Map<List<HmoDTO>>(await _hmoRepository.GetAllAsync());
        }



        public async Task<HmoDTO> UpdateAsync(HmoDTO Hmo)
        {
            HMO r = _mapper.Map<HMO>(Hmo);
            return _mapper.Map<HmoDTO>(await _hmoRepository.UpdateAsync(r));
        }

    }
}
