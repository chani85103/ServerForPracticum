using AutoMapper;
using Clients.Common.DTO_s;
using Clients.Repository.Entities;
using Clients.Repository.Interfaces;
using Clients.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Services.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<Common.DTO_s.ClientDTO> AddAsync(Common.DTO_s.ClientDTO client)
        {
            //// client.Children = null;
            //HmoDTO h= client.HMO;
            //client.HMO = null;
            //Client client1 = _mapper.Map<Client>(client);
            //client1.HMO=_mapper.Map<HMO>(h);
            ////foreach (var child in client.Children)
            ////{
            ////    Child c1 = new Child(child.Id, child.FirstName, child.BirthDate, client1);

            ////   await  _childRepository.AddAsync(c1 );
            ////}

            //client1 = await _clientRepository.AddAsync(client1);
            //return client;
            Client c= _mapper.Map<Client>(client);
            ClientDTO cd= _mapper.Map<ClientDTO>(await _clientRepository.AddAsync(c));
            return cd;
        }

        public async Task<List<Common.DTO_s.ClientDTO>> GetListAsync()
        {
            return _mapper.Map<List<Common.DTO_s.ClientDTO>>(await _clientRepository.GetAllAsync());
        }

        public async Task<bool> IsExistsAsync(string id)
        {
            return await _clientRepository.IsExistsAsync(id);
        }


        public async Task DeleteAsync(string id)
        {
            await _clientRepository.DeleteAsync(id);
        }

        public async Task<ClientDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<ClientDTO>(await _clientRepository.GetByIdAsync(id));

        }




        public async Task<List<ChildDTO>> UpdateAsync(string id,ChildDTO[] children)
        {
            //// client.Children = null; client.HMO = null;
            // Child[] c = _mapper.Map<Child[]>(children);
            // Client client = await _clientRepository.UpdateAsync(id, c);
            // HmoDTO hmo = _mapper.Map<HmoDTO>(client.MyImpression);
            // client.MyImpression = null;
            // ClientDTO c2 = _mapper.Map<ClientDTO>(client);
            // c2.MyImpression= hmo.Name;
            // return c2;
            Child[] c = _mapper.Map<Child[]>(children);
          List<Child>cn = await _clientRepository.UpdateAsync(id, c);
            return _mapper.Map<List<ChildDTO>>(cn);
        }
    }
}
